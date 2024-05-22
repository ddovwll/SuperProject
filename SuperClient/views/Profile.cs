using SuperClient.models;
using SuperClient.presenters;
using SuperClient.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperClient
{
    public partial class Profile : Form, IProfileView
    {
        private readonly IProfilePresenter presenter;

        public Profile()
        {
            InitializeComponent();
            presenter = new ProfilePresenter(this);
            label1.Text = headers.header.NickName;
            LoadPosts();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            menu.Show();
            this.Hide();
            this.Dispose();
        }

        public async void CreatePost_Click(object sender, EventArgs e)
        {
            await presenter.CreatePost(NameNewPost.Text, TextNewPost.Text, headers.header.userId);

            if (presenter.resultAuth == "ok")
            {
                MessageBox.Show("Пост успешно опубликован");
                LoadPosts();
            }
            else
            {
                MessageBox.Show(presenter.resultAuth);
                NameNewPost.Clear();
                TextNewPost.Clear();
            }
        }

        public async void LoadPosts()
        {
            List<Post> posts = await presenter.UserPosts(headers.header.NickName);
            DisplayPosts(posts);
        }

        public void DisplayPosts(List<Post> posts)
        {
            // Очистить существующие элементы управления
            flowLayoutPanelUserPosts.Controls.Clear();

            flowLayoutPanelUserPosts.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelUserPosts.WrapContents = false;

            foreach (var post in posts)
            {
                // Создать метку для отображения заголовка поста
                TextBox tbTitle = new TextBox();
                tbTitle.Text = post.header;
                tbTitle.ReadOnly = true;
                tbTitle.BorderStyle = BorderStyle.None; // Убрать границы 
                tbTitle.Width = 800; // Фиксированная ширина
                tbTitle.BackColor = Color.CornflowerBlue;
                tbTitle.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                tbTitle.TextAlign = HorizontalAlignment.Left; // Выравнивание по левому краю
                flowLayoutPanelUserPosts.Controls.Add(tbTitle);

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
                flowLayoutPanelUserPosts.Controls.Add(rtbText);

                // Создать метку для отображения лайков поста
                System.Windows.Forms.Label lbLikes = new System.Windows.Forms.Label();
                lbLikes.BackColor = Color.CornflowerBlue;
                lbLikes.AutoSize = false;
                lbLikes.Image = ResizeImage(Image.FromFile("C:\\Users\\user\\RiderProjects\\SuperProject\\SuperClient\\Resources\\images\\red_heart.png"), 20, 20);
                lbLikes.ImageAlign = ContentAlignment.MiddleLeft; // Выравниваем картинку по левому краю
                lbLikes.TextAlign = ContentAlignment.MiddleCenter; // Выравниваем текст по центру
                lbLikes.Text = post.likesCount.ToString();

                flowLayoutPanelUserPosts.Controls.Add(lbLikes);

                // Создать панель для размещения кнопок (чтобы они располагались рядом друг с другом, а не одна под другой)
                FlowLayoutPanel buttonPanel = new FlowLayoutPanel();
                buttonPanel.FlowDirection = FlowDirection.LeftToRight;
                buttonPanel.AutoSize = true;
                buttonPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                flowLayoutPanelUserPosts.Controls.Add(buttonPanel);

                // Создать кнопку "изменить"
                Button btnUpdate = new Button();
                btnUpdate.Text = "Изменить";
                btnUpdate.AutoSize = true;
                btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText; // Установить изображение перед текстом
                btnUpdate.BackColor = Color.SkyBlue;
                btnUpdate.Image = ResizeImage(Image.FromFile("C:\\Users\\user\\RiderProjects\\SuperProject\\SuperClient\\Resources\\images\\pen.png"), 20, 20);

                post.IsUpdated = false; // до нажатия кнопки изменения пост не изменен

                // Создать обработчик события для кнопки "изменить"
                btnUpdate.Click += async (sender, e) =>
                {
                    // Если пост еще не изменен пользователем, то изменяем и сохраняем
                    if (post.IsUpdated != true)
                    {
                        btnUpdate.Text = "Сохранить";

                        // открываем для изменения заголовок и текст поста
                        tbTitle.ReadOnly = false;
                        rtbText.ReadOnly = false;
                        tbTitle.BackColor = Color.White;
                        rtbText.BackColor = Color.White;

                        post.IsUpdated = true;
                    }
                    // Иначе снимаем лайк и уменьшаем счетчик
                    else
                    {
                        // запоминаем новый вариант поста
                        string headerAfterUpdate = tbTitle.Text;
                        string textAfterUpdate = rtbText.Text;

                        await presenter.UpdatePost(post.id, headerAfterUpdate, textAfterUpdate); // вызов запроса на изменение поста

                        if (presenter.resultAuth == "ok")
                        {
                            MessageBox.Show("Пост успешно изменен");
                            LoadPosts();
                        }
                        else
                        {
                            MessageBox.Show(presenter.resultAuth);
                            tbTitle.Text = post.header;
                            rtbText.Text = post.text;
                        }

                        post.IsUpdated = false;

                        // закрываем для изменения заголовок и текст поста
                        tbTitle.ReadOnly = true;
                        rtbText.ReadOnly = true;
                        tbTitle.BackColor = Color.CornflowerBlue;
                        rtbText.BackColor = Color.CornflowerBlue;

                        btnUpdate.Text = "Изменить";
                    }
                };

                // Добавить кнопку изменения к панели
                buttonPanel.Controls.Add(btnUpdate);

                // Создать кнопку "удалить"
                Button btnDelete = new Button();
                btnDelete.Text = "Удалить";
                btnDelete.AutoSize = true;
                btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText; // Установить изображение перед текстом
                btnDelete.BackColor = Color.Crimson;
                btnDelete.Image = ResizeImage(Image.FromFile("C:\\Users\\user\\RiderProjects\\SuperProject\\SuperClient\\Resources\\images\\garbage.png"), 20, 20);

                // Создать обработчик события для кнопки "удалить"
                btnDelete.Click += async (sender, e) =>
                {
                    await presenter.DeletePost(post.id); // вызов запроса на удаление

                    if (presenter.resultAuth == "ok")
                    {
                        MessageBox.Show("Пост успешно удален");
                        LoadPosts();
                    }
                    else
                    {
                        MessageBox.Show(presenter.resultAuth);
                    }
                };

                // Добавить кнопку удаления к панели
                buttonPanel.Controls.Add(btnDelete);
            }

            // Обновить макет для обновления полос прокрутки
            flowLayoutPanelUserPosts.PerformLayout();
        }

        public Image ResizeImage(Image imgToResize, int width, int height) // для изменения размера картинки
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage((Image)bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, width, height);
            }
            return (Image)bmp;
        }
        
        public void OnFormClosed(object sender, EventArgs e) => Authorization.mainForm.Close();
    }
}
