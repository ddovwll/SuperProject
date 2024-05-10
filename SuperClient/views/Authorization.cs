using SuperClient.models;
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
            MessageBox.Show(presenter.resultAuth);
            if (presenter.resultAuth == "ok")
            {
                mainMenu menu = new mainMenu();
                menu.Show();
                this.Hide();
            }
            //MessageBox.Show(_headers.sessionId);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            register formRegister = new register();
            formRegister.Show();
            this.Hide();
        }
    }
}
