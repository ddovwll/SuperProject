using SuperClient.models;
using SuperClient.presenters;
using SuperClient.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SuperClient.views
{
    public partial class Authorization : Form, IAuthorizationView
    {
        private readonly IAuthorizationPresenter presenter;
        public static Form mainForm;
        
        public Authorization()
        {
            InitializeComponent();
            presenter = new AuthorizationPresenter(this);
            mainForm = this;
        }

        private async void buttonAuthorization_Click(object sender, EventArgs e)
        {
            await presenter.Authorization(textBoxName.Text, textBoxPassword.Text);
            var _headers = headers.header;
            if (presenter.resultAuth == "ok")
            {
                MessageBox.Show("Вы выполнили вход в аккаунт nickname: " + textBoxName.Text);
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
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            register formRegister = new register();
            formRegister.Show();
        }
    }
}
