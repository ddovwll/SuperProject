using SuperClient.models;
using SuperClient.presenters;
using SuperClient.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private async void CreatePost_Click(object sender, EventArgs e)
        {
            await presenter.CreatePost(NameNewPost.Text, TextNewPost.Text, headers.header.userId, headers.header.NickName);
            
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
    }
}
