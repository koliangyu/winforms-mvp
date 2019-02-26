using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMVP.Models;
using WinFormsMVP.Presenters;

namespace WinFormsMVP.Views
{
    public partial class UserForm : Form, IUserView
    {
        private UserPresenter _presenter;

        public UserForm()
        {
            _presenter = new UserPresenter(this);

            InitializeComponent();
        }

        public string SearchUser { get { return searchUserTextBox.Text; } }

        public string UserName { set { userNameLabel.Text = value; } }
        public string UserAddress { set { userAddressLabel.Text = value; } }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _presenter.OnUserSearched();
        }
    }
}
