using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NhậnDiệnBiểnSốXe.Models;

namespace NhậnDiệnBiểnSốXe.Views
{
    public partial class ManagerAdminUserControl : UserControl,IAdminsBDX
    {
        AdminsManager adminsManagerInstance = AdminsManager.getAdminsManagerInstance();
        List<UserInfo> listAdmin;
        int Index;
        public ManagerAdminUserControl()
        {
            InitializeComponent();
            listAdmin = adminsManagerInstance.getListAdmin();
            adminsManagerInstance.addObserver(this);
            adminsListView.DataSource = listAdmin;
        }
        public void UpdateListAdmin()
        {
            listAdmin = adminsManagerInstance.getListAdmin();
            adminsListView.DataSource = listAdmin;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            
            userInfo.userName = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            int role = 1;
            if (cbxRole.Text != "Admin")
            {
                role = 2;
            }
            userInfo.role = role;

            int isActive = 0;
            if (cbxIsActive.Text == "Đang hoạt động")
            {
                isActive = 1;
            }
            userInfo.isActive = isActive;
            Guid id = Guid.NewGuid();
            userInfo.userId = id.ToString();
            adminsManagerInstance.addAdmin(userInfo, password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.userId = adminsListView.Rows[Index].Cells[0].Value.ToString();
            userInfo.userName = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            int role = 1;
            if (cbxRole.Text != "Admin")
            {
                role = 2;
            }
            userInfo.role = role;

            int isActive = 0;
            if (cbxIsActive.Text == "Đang hoạt động")
            {
                isActive = 1;
            }
            userInfo.isActive = isActive;
            adminsManagerInstance.updateAdmin(userInfo, password);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.userId = adminsListView.Rows[Index].Cells[0].Value.ToString();
            adminsManagerInstance.removeAdmin(userInfo);
        }

        private void adminsListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            Index = numrow;
            txtUsername.Text = adminsListView.Rows[numrow].Cells[1].Value.ToString();
                cbxRole.Text = "User";
                cbxIsActive.Text = "Không hoạt động";
                if (adminsListView.Rows[numrow].Cells[2].Value.ToString() == "1")
                {
                    cbxRole.Text = "Admin";
                }

                if (adminsListView.Rows[numrow].Cells[3].Value.ToString() == "1")
                {
                    cbxIsActive.Text = "Đang hoạt động";
                }
        }
    }
}
