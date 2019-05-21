using NhậnDiệnBiểnSốXe.Models;
using NhậnDiệnBiểnSốXe.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhậnDiệnBiểnSốXe
{
    public partial class MainForm : Form,IUserInfoBDX
    {
        LoginUserControl login = new LoginUserControl();
        ManagerAdminUserControl managerAdmin = new ManagerAdminUserControl();
        ManagerTickerUserControl managerTicker = new ManagerTickerUserControl();
        ManagerLogUserControl managerLog = new ManagerLogUserControl();

        UserInfoManager userInfoManagerInstance = UserInfoManager.getUserInfoManagerInstance();
        UserInfo userInfo;
     
        public MainForm()
        {
            InitializeComponent();
            userInfoManagerInstance.addObserver(this);
            this.checkUserInfo();
            
        }
        private void checkUserInfo()
        {
            userInfo = userInfoManagerInstance.getUserInfo();
            if (userInfo.userId == null)
            {
                login.Dock = DockStyle.Fill;
                this.Controls.Add(login);
                this.menuStrip1.Visible = false;
            }
            else
            {
                this.Controls.Remove(login);
                managerAdmin.Dock = DockStyle.Fill;
                this.Controls.Add(managerAdmin);
                this.menuStrip1.Visible = true;
            }
        }
        private void quảnLýAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(managerTicker);
            this.Controls.Remove(managerLog);
            managerAdmin.Dock = DockStyle.Fill;
            this.Controls.Add(managerAdmin);
        }

        private void quảnLýVéXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(managerAdmin);
            this.Controls.Remove(managerLog);
            managerTicker.Dock = DockStyle.Fill;
            this.Controls.Add(managerTicker);
        }
        private void quảnLýXeVàoBãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraInForm cameraIn = new CameraInForm();
            cameraIn.Show();

        }
        private void quảnLýXeRaBãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraOutForm cameraOut = new CameraOutForm();
            cameraOut.Show();
        }
        private void thôngTinXeRaVàoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(managerAdmin);
            this.Controls.Remove(managerTicker);
            managerLog.Dock = DockStyle.Fill;
            this.Controls.Add(managerLog);
        }
        public void UpdateUserInfo()
        {
            this.checkUserInfo();
        }
    }
}
