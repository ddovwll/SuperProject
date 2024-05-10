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
    public partial class ProfileView : Form, IProfileView
    {
        private readonly IProfilePresenter presenter;
        public ProfileView()
        {
            InitializeComponent();
            presenter = new ProfilePresenter(this);
        }
    }
}
