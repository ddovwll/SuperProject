using SuperClient.presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperClient.views
{
    public partial class LikedPosts : Form, ILikedPostsView
    {
        private readonly ILikedPostsPresenter presenter;

        public LikedPosts()
        {
            InitializeComponent();
            presenter = new ILikedPostsPresenter(this);
            LikedPosts();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            menu.Show();
        }

        public void DisplayPosts(List<LikedPosts> posts)
        {
            // Очистить существующие элементы управления
            flowLayoutPanelLickedPost.Controls.Clear();

            flowLayoutPanelLickedPost.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelLickedPost.WrapContents = false;

            foreach (var post in posts)
            {
                // Создать метку для отображения никнейма
                TextBox tbUsername = new TextBox();
                tbUsername.Text = post.userName;
                tbUsername.ReadOnly = true;
                tbUsername.BorderStyle = BorderStyle.None; // Убрать границы 
                tbUsername.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                tbUsername.BackColor = Color.CornflowerBlue;
                tbUsername.Width = 800; // Фиксированная ширина
                tbUsername.TextAlign = HorizontalAlignment.Left; // Выравнивание по левому краю
                flowLayoutPanelLickedPost.Controls.Add(tbUsername);

                // Создать метку для отображения заголовка поста
                TextBox tbTitle = new TextBox();
                tbTitle.Text = post.header;
                tbTitle.ReadOnly = true;
                tbTitle.BorderStyle = BorderStyle.None; // Убрать границы 
                tbTitle.Width = 800; // Фиксированная ширина
                tbTitle.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                tbTitle.BackColor = Color.CornflowerBlue;
                tbTitle.TextAlign = HorizontalAlignment.Left; // Выравнивание по левому краю
                flowLayoutPanelLickedPost.Controls.Add(tbTitle);

                // Создать ричтекстбокс для отображения текста поста
                RichTextBox rtbText = new RichTextBox();
                rtbText.Text = post.text;
                rtbText.ReadOnly = true;
                rtbText.Font = new Font("Segoe UI", 9);
                rtbText.BorderStyle = BorderStyle.None; // Убрать границы ричтекстбокса
                rtbText.WordWrap = true; // Переносить слова по нужности
                rtbText.Width = 800; // Фиксированная ширина
                rtbText.BackColor = Color.CornflowerBlue;
                int textHeight = TextRenderer.MeasureText(rtbText.Text, rtbText.Font, new Size(rtbText.Width, int.MaxValue), TextFormatFlags.WordBreak).Height;
                rtbText.Height = textHeight + 5; // 5 - дополнительный отступ
                rtbText.SelectionAlignment = HorizontalAlignment.Left; // Выравнивание по левому краю
                flowLayoutPanelLickedPost.Controls.Add(rtbText);

                // Создать кнопку "лайк"
                Button btnLike = new Button();
                btnLike.Text = post.likesCount.ToString();
                btnLike.AutoSize = true;
                btnLike.TextImageRelation = TextImageRelation.ImageBeforeText; // Установить изображение перед текстом

                // Установить изображение и цвет кнопки в зависимости от состояния лайка
                UpdateLikeButton(btnLike, post);

                // Создать обработчик события для кнопки лайка
                btnLike.Click += (sender, e) =>
                {
                    // Если пост еще не лайкнут пользователем, лайкаем и увеличиваем счетчик
                    if (post.IsLiked != true)
                    {
                        presenter.CreateLike(post.id);
                        post.likesCount++;
                        post.IsLiked = true;
                    }
                    // Иначе снимаем лайк и уменьшаем счетчик
                    else
                    {
                        presenter.DeleteLike(post.id);
                        post.likesCount--;
                        post.IsLiked = false;
                    }

                    // Обновляем текст кнопки и изображение в зависимости от состояния лайка
                    btnLike.Text = post.likesCount.ToString();
                    UpdateLikeButton(btnLike, post);
                };

                // Добавить кнопку лайка к контейнеру поста
                flowLayoutPanelLickedPost.Controls.Add(btnLike);
            }

            // Обновить макет для обновления полос прокрутки
            flowLayoutPanelLickedPost.PerformLayout();
        }



        private void LikedPosts_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
