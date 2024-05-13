using SuperClient.models;
using SuperClient.presenters;
using SuperClient.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Menu_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            menu.Show();
        }

        public async void LoadPosts()
        {
            List<Post> posts = await presenter.UserPosts(headers.header.NickName);
            DisplayPosts(posts);
        }

        public void DisplayPosts(List<Post> posts)
        {
            // Очищаем RichTextBox от предыдущих постов
            UserPosts.Clear();

            // Создаем объект Font с заданным размером шрифта
            Font titleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Font textFont = new Font("Segoe UI", 9);

            // Выводим посты в RichTextBox
            foreach (var post in posts)
            {
                // Создаем панель для каждого поста
                Panel postPanel = new Panel();
                postPanel.BorderStyle = BorderStyle.FixedSingle;
                postPanel.Dock = DockStyle.Top;
                postPanel.AutoSize = true;

                // Создаем текстовое поле для заголовка
                TextBox titleTextBox = new TextBox();
                titleTextBox.Text = post.header;
                titleTextBox.ReadOnly = true;
                titleTextBox.Dock = DockStyle.Top;
                titleTextBox.BorderStyle = BorderStyle.None;
                titleTextBox.BackColor = SystemColors.Control;
                titleTextBox.Margin = new Padding(5);
                titleTextBox.Font = titleFont;

                // Создаем редактируемое текстовое поле для текста поста
                RichTextBox textRichTextBox = new RichTextBox();
                textRichTextBox.Text = post.text;
                textRichTextBox.ReadOnly = true;
                textRichTextBox.Dock = DockStyle.Fill;
                textRichTextBox.BorderStyle = BorderStyle.None;
                textRichTextBox.BackColor = SystemColors.Control;
                textRichTextBox.Margin = new Padding(5);
                textRichTextBox.Font = textFont;

                // Создаем кнопки удаления и редактирования для каждого поста
                Button deleteButton = new Button();
                deleteButton.Text = "Удалить";
                deleteButton.Tag = post; // Сохраняем ссылку на пост в Tag кнопки
                deleteButton.Dock = DockStyle.Bottom;
                deleteButton.Click += DeleteButton_Click;

                Button editButton = new Button();
                editButton.Text = "Редактировать";
                editButton.Tag = post; // Сохраняем ссылку на пост в Tag кнопки
                editButton.Dock = DockStyle.Bottom;
                editButton.Click += EditButton_Click;

                // Добавляем элементы в панель
                postPanel.Controls.Add(titleTextBox);
                postPanel.Controls.Add(textRichTextBox);
                postPanel.Controls.Add(deleteButton);
                postPanel.Controls.Add(editButton);

                // Добавляем панель с постом в контейнер
                UserPosts.Controls.Add(postPanel);
            }

            // Освобождаем ресурсы шрифтов
            titleFont.Dispose();
            textFont.Dispose();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Получаем пост, к которому относится кнопка удаления
            Button button = (Button)sender;
            Post post = (Post)button.Tag;

            presenter.DeletePost(post.id); // вызов запроса на удаление
            LoadPosts(); // выводим обновленную ленту постов юзера
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Получаем пост, к которому относится кнопка редактирования
            Button button = (Button)sender;
            Post post = (Post)button.Tag;

            //titleTextBox.ReadOnly = false; // разрешаем изменение

            presenter.UpdatePost(post.id, post.header, post.text); // вызов запроса на изменение поста
            LoadPosts(); // выводим обновленную ленту постов юзера
        }


    }
}
