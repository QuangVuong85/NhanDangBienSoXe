using NhậnDiệnBiểnSốXe.Constants;
using NhậnDiệnBiểnSốXe.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhậnDiệnBiểnSốXe.DataConnection
{
    class TickerConnection
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static void openketnoi()
        {
            con = new SqlConnection(DataBaseConstant.CHUOI_KET_NOI);
            con.Open();
        }
        public static void dongketnoi()
        {
            con.Close();
        }
        public List<TickerInfo> getAllTicker()
        {
            List<TickerInfo> result = new List<TickerInfo>();
            string query = "select * from tbl_VeThang";
            try
            {
                openketnoi();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                // loi get du lieu 
                while (reader.Read())
                {
                    var tmpTickerInfo = new TickerInfo();

                    tmpTickerInfo.tickerId = reader.GetString(0);
                    tmpTickerInfo.bienso = reader.GetString(1);
                    tmpTickerInfo.username = reader.GetString(2);
                    tmpTickerInfo.cmnd = reader.GetString(3);
                    tmpTickerInfo.type = Convert.ToInt32(reader.GetValue(4));
                    tmpTickerInfo.isActive = Convert.ToInt32(reader.GetValue(5));
                    tmpTickerInfo.deadline = reader.GetString(6);
                    result.Add(tmpTickerInfo);
                }
                dongketnoi();
            }
            catch (Exception e)
            {
                dongketnoi();
            }
            return result;
        }
        public bool addInfoTicker(TickerInfo tickerInfo)
        {

            try
            {
                openketnoi();
                string Add = "insert into tbl_VeThang values(" +
                              "'" + tickerInfo.tickerId + "'," +
                              "'" + tickerInfo.bienso + "'" +
                              ",N'" + tickerInfo.username + "'," +
                              "'" + tickerInfo.cmnd + "'," +
                              "" + tickerInfo.type + "," +
                              "" + tickerInfo.isActive + "," +
                              "'" + tickerInfo.deadline + "')";
                SqlCommand cmd = new SqlCommand(Add, con);
                int result = cmd.ExecuteNonQuery();
                dongketnoi();
                if (result == 1)
                {
                    MessageBox.Show("Thêm vé thành công");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm vé xe");
                return false;
            }

        }
        public bool updateInfoTicker(TickerInfo tickerInfo,String id)
        {
            try
            {
                if (tickerInfo.tickerId == null)
                {
                    MessageBox.Show("Chưa chọn vé để cập nhật");
                }
                else
                {
                    openketnoi();
                    string Update = "update tbl_VeThang " +
                        "set bienso ='" + tickerInfo.bienso + "'," +
                         "id = '" + id + "'," +
                        "username = N'" + tickerInfo.username + "'," +
                        " cmnd = '" + tickerInfo.cmnd + "'," +
                        " type = '" + tickerInfo.type + "'," +
                        "isActive ='" + tickerInfo.isActive + "'," +
                        "ngayhethan = '"+tickerInfo.deadline+"'" +
                        "where id = '" + tickerInfo.tickerId + "'";
                    SqlCommand cmd = new SqlCommand(Update, con);
                    int result = cmd.ExecuteNonQuery();
                    dongketnoi();
                    if (result == 1)
                    {
                        MessageBox.Show("Cập nhật vé thành công");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật vé xe");
                return false;
            }
            return true;
        }
        public bool deleteTicker(TickerInfo tickerInfo)
        {
            try
            {
                openketnoi();
                string Delete = "delete tbl_VeThang from tbl_VeThang where id = '" + tickerInfo.tickerId + "'";
                SqlCommand cmd = new SqlCommand(Delete, con);
                int result = cmd.ExecuteNonQuery();
                dongketnoi();
                if (result == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi xóa vé xe");
                return false;
            }
        }
        public TickerInfo ticker(string id, string biensoVao)
        {
            TickerInfo ticker = new TickerInfo();
            string query = "select * from tbl_VeThang where id = '" + id + "'";
            try
            {
                openketnoi();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string biensoDK = reader["bienso"].ToString();
                if (biensoDK != null && biensoDK != "")
                {
                    if (biensoDK == biensoVao)
                    {
                        ticker.tickerId = reader["id"].ToString();
                        ticker.bienso = biensoDK;
                        ticker.type = int.Parse(reader["type"].ToString());
                        //ticker.userName = username;
                        //userInfo.role = int.Parse(reader["role"].ToString());
                        //userInfo.isActive = int.Parse(reader["isActive"].ToString());
                        TickerInforManager updateTickerInfo = TickerInforManager.getTickerInfoManagerInstance();
                        updateTickerInfo.updateTickerInfo(ticker);
                    }
                    else
                    {
                        MessageBox.Show("Biển số không khớp với biển số đăng ký");

                    }
                }
                else
                {
                    MessageBox.Show("ID Thẻ không tồn tại");

                }
                dongketnoi();
            }
            // Mã thẻ sai
            catch
            {
                dongketnoi();
               // MessageBox.Show("ID Thẻ không tồn tại");
            }
            return ticker;
        }
    }
}
