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
    public partial class register : Form, IregisterView
    {
        private readonly IregisterPresenter presenter;

        public register()
        {
            InitializeComponent();
            presenter = new registerPresenter(this);
        }

        private async void buttonRegistration_Click(object sender, EventArgs e)
        {
            if(InputValidator.IsUsernameValid(textBoxNickName.Text) && InputValidator.IsPasswordValid(textBoxPassword.Text))
            {
                await presenter.Register(textBoxNickName.Text, textBoxPassword.Text);
                var _headers = headers.header;
                //MessageBox.Show(presenter.resultRegistr);
                if (presenter.resultRegistr == "ok")
                {
                    MessageBox.Show("Аккаунт успешно зарегистрирован");
                    Authorization auth = new Authorization();
                    auth.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(presenter.resultRegistr);
                }
            }
            else
            {
                MessageBox.Show("Имя пользователя и пароль должны содержать в себе только буквы\nИмя пользователя и пароль не должны быть пустыми\nДлина пароль должна быть больше 5 символов ");
                textBoxNickName.Clear();
                textBoxPassword.Clear();
            }
        }

        private void register_Load(object sender, EventArgs e)
        {
        }
    }
}
