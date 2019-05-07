using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NhậnDiệnBiểnSốXe.DataConnection;

namespace NhậnDiệnBiểnSốXe.Views
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text;
            string password = this.txtPassword.Text;
            UserConnection userConnection = new UserConnection();
            if (username != "" && password != "")
            {
                userConnection.Login(username, password);
            }
        }
    }
}
