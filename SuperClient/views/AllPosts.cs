using SuperClient.models;
using SuperClient.presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperClient.views
{
    public partial class AllPosts : Form, IAllPostsView
    {
        private readonly IAllPostsPresenter presenter;

        public AllPosts()
        {
            InitializeComponent();
            presenter = new AllPostsPresenter(this);
            LoadPosts();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            menu.Show();
            this.Hide();
            this.Dispose();
        }

        public async void LoadPosts()
        {
            List<Post> posts = await presenter.AllPosts();
            DisplayPosts(posts);
        }

        public void DisplayPosts(List<Post> posts)
        {
            // Очистить существующие элементы управления
            flowLayoutPanelPosts.Controls.Clear();

            flowLayoutPanelPosts.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelPosts.WrapContents = false;

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
                flowLayoutPanelPosts.Controls.Add(tbUsername);

                // Создать метку для отображения заголовка поста
                TextBox tbTitle = new TextBox();
                tbTitle.Text = post.header;
                tbTitle.ReadOnly = true;
                tbTitle.BorderStyle = BorderStyle.None; // Убрать границы 
                tbTitle.Width = 800; // Фиксированная ширина
                tbTitle.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                tbTitle.BackColor = Color.CornflowerBlue;
                tbTitle.TextAlign = HorizontalAlignment.Left; // Выравнивание по левому краю
                flowLayoutPanelPosts.Controls.Add(tbTitle);

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
                flowLayoutPanelPosts.Controls.Add(rtbText);

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
                flowLayoutPanelPosts.Controls.Add(btnLike);
            }

            // Обновить макет для обновления полос прокрутки
            flowLayoutPanelPosts.PerformLayout();
        }

        public void UpdateLikeButton(Button btnLike, Post post)
        {
            // Установить изображение и цвет кнопки в зависимости от состояния лайка
            if (post.IsLiked)
            {
                btnLike.BackColor = Color.Pink; // Розовый цвет, если пост лайкнут
                btnLike.Image = ResizeImage(Image.FromFile("C:\\Users\\user\\RiderProjects\\SuperProject\\SuperClient\\Resources\\images\\red_heart.png"), 20, 20);
            }
            else
            {
                btnLike.BackColor = Color.White; // Белый цвет, если пост не лайкнут
                btnLike.Image = ResizeImage(Image.FromFile("C:\\Users\\user\\RiderProjects\\SuperProject\\SuperClient\\Resources\\images\\black_heart.png"), 20, 20);
            }
        }

        public Image ResizeImage(Image imgToResize, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage((Image)bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, width, height);
            }
            return (Image)bmp;
        }

        private void flowLayoutPanelPosts_Paint(object sender, PaintEventArgs e)
        {

        }

        public void OnFormClosed(object sender, EventArgs e) => Authorization.mainForm.Close();
    }
}
