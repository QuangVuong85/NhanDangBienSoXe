using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NhậnDiệnBiểnSốXe.Models;
using System.Globalization;

namespace NhậnDiệnBiểnSốXe.Views
{
    public partial class ManagerTickerUserControl : UserControl, ITickersBDX
    {
        TickersManager tickersManagerInstance = TickersManager.getTickersManagerInstance();
        List<TickerInfo> listTicker;
        int Index;
        public ManagerTickerUserControl()
        {
            InitializeComponent();
            listTicker = tickersManagerInstance.getListTicker();
            tickersManagerInstance.addObserver(this);
            tickersListView.DataSource = listTicker;

            tickersListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }
        public void UpdateListTicker()
        {
            listTicker = tickersManagerInstance.getListTicker();
            tickersListView.DataSource = listTicker;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(dateDeadline.Value.ToLongTimeString());
            TickerInfo tickerInfo = new TickerInfo();
            tickerInfo.tickerId = this.txtId.Text;
            tickerInfo.bienso = this.txtBienso.Text;
            tickerInfo.username = this.txtName.Text;
            tickerInfo.cmnd = this.txtCmnd.Text;
            
            tickerInfo.deadline = dateDeadline.Value.ToShortDateString();
            //Convert.ToInt32(((DateTimeOffset)dateDeadline.Value.Date).ToUnixTimeSeconds());
            int type = 1;
            if (cbxType.Text != "Vé Tháng")
            {
                type = 0;
            }
            tickerInfo.type = type;

            int isActive = 0;
            if (cbxIsActive.Text == "Đang hoạt động")
            {
                isActive = 1;
            }
            tickerInfo.isActive = isActive;
            tickersManagerInstance.addTicker(tickerInfo);
        }

       
        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            TickerInfo tickerInfo = new TickerInfo();
            String id = txtId.Text;
            tickerInfo.tickerId = tickersListView.Rows[Index].Cells[0].Value.ToString();
            tickerInfo.bienso = this.txtBienso.Text;
            tickerInfo.username = this.txtName.Text;
            tickerInfo.cmnd = this.txtCmnd.Text;
            int type = 1;
            if (cbxType.Text != "Vé Tháng")
            {
                type = 0;
            }
            tickerInfo.type = type;

            int isActive = 0;
            if (cbxIsActive.Text == "Đang hoạt động")
            {
                isActive = 1;
            }
            tickerInfo.isActive = isActive;
            tickerInfo.deadline = dateDeadline.Value.ToShortDateString();
            tickersManagerInstance.updateTicker(tickerInfo, id);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TickerInfo tickerInfo = new TickerInfo();
            tickerInfo.tickerId = tickersListView.Rows[Index].Cells[0].Value.ToString();
            tickersManagerInstance.removeTicker(tickerInfo);
        }
        private void tickersListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tickersListView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            Index = numrow;

            txtId.Text = tickersListView.Rows[numrow].Cells[0].Value.ToString();
            txtBienso.Text = tickersListView.Rows[numrow].Cells[1].Value.ToString();
            txtName.Text = tickersListView.Rows[numrow].Cells[2].Value.ToString();
            txtCmnd.Text = tickersListView.Rows[numrow].Cells[3].Value.ToString();

            cbxType.Text = "Vé Ngày";
            cbxIsActive.Text = "Không hoạt động";
            if (tickersListView.Rows[numrow].Cells[4].Value.ToString() == "1")
            {
                cbxType.Text = "Vé Tháng";
            }
            if (tickersListView.Rows[numrow].Cells[5].Value.ToString() == "1")
            {
                cbxIsActive.Text = "Đang hoạt động";
            }
            DateTime dt = DateTime.ParseExact(tickersListView.Rows[numrow].Cells[6].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            dateDeadline.Value = dt;
        }
    }
}
