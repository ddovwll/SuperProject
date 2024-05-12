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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperClient.views
{
    public partial class AllPosts : Form, IAllPostsView
    {
        private readonly IAllPostsPresenter presenter;
        public AllPosts()
        {
            InitializeComponent();
            presenter = new AllPostsPresenter(this);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            menu.Show();
        }

        
    }
}
