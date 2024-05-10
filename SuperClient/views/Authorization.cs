using SuperClient.models;
using SuperClient.presenters;
using SuperClient.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SuperClient.views
{
    public partial class Authorization : Form, IAuthorizationView
    {
        private readonly IAuthorizationPresenter presenter;

        public Authorization()
        {
            InitializeComponent();
            presenter = new AuthorizationPresenter(this);
        }

        private async void buttonAuthorization_Click(object sender, EventArgs e)
        {
            await presenter.Authorization(textBoxName.Text, textBoxPassword.Text);
            var _headers = headers.header;
            if (presenter.resultAuth == "ok")
            {
                MessageBox.Show("Вы выполнили вход в аккаунт nickname: " + textBoxName.Text);
                MessageBox.Show(_headers.sessionId);
                mainMenu menu = new mainMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(presenter.resultAuth);
                textBoxName.Clear();
                textBoxPassword.Clear();
            }

            //MessageBox.Show(_headers.sessionId);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            register formRegister = new register();
            formRegister.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
