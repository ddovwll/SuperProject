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
            await presenter.Register(textBoxNickName.Text, textBoxPassword.Text);
            var _headers = headers.header;
            MessageBox.Show(presenter.resultRegistr);
            if (presenter.resultRegistr == "ok")
            {
                mainMenu menu = new mainMenu();
                menu.Show();
                this.Hide();
            }
        }

        private void register_Load(object sender, EventArgs e)
        {
        }
    }
}
