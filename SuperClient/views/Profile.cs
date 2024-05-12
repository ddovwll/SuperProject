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
        }

        private async void CreatePost_Click(object sender, EventArgs e)
        {
            await presenter.CreatePost(NameNewPost.Text, TextNewPost.Text, headers.header.userId);

            if (presenter.resultAuth == "ok")
            {
                MessageBox.Show("Пост успешно опубликован");
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
    }
}
