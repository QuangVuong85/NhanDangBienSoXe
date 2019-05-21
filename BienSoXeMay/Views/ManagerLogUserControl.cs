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
    public partial class ManagerLogUserControl : UserControl,ILogsBDX
    {
        LogsManager logsManagerInstance = new LogsManager();
        List<LogInfo> listLog;
        public ManagerLogUserControl()
        {
            InitializeComponent();
            listLog = logsManagerInstance.getListLog();
            logsManagerInstance.addObserver(this);
            dataGridView1.DataSource = listLog;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //name column
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã vé vào";
            dataGridView1.Columns[2].HeaderText = "Thời gian vào";
            dataGridView1.Columns[3].HeaderText = "Thời gian ra";
            dataGridView1.Columns[4].HeaderText = "Biển số vào";
            dataGridView1.Columns[5].HeaderText = "Biển số ra";
            dataGridView1.Columns[6].HeaderText = "Hình ảnh vào";
            dataGridView1.Columns[7].HeaderText = "Hình ảnh ra";
            dataGridView1.Columns[8].HeaderText = "Kiểu";
        }
        public void UpdateListLog()
        {
            listLog = logsManagerInstance.getListLog();
            dataGridView1.DataSource = listLog;
        }
    }
}
