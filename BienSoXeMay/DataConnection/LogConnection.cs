using NhậnDiệnBiểnSốXe.Constants;
using NhậnDiệnBiểnSốXe.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace NhậnDiệnBiểnSốXe.DataConnection
{
    class LogConnection
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

        public List<LogInfo> getAllLog()
        {
            List<LogInfo> result = new List<LogInfo>();
            string query = "select * from tbl_log";
            try
            {
                openketnoi();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                // loi get du lieu 
                while (reader.Read())
                {
                    var tmpLogInfo = new LogInfo();
                 //   tmpLogInfo.id = reader.GetString(0);
                    tmpLogInfo.idve = reader.GetString(1);
                    tmpLogInfo.time_In = reader.GetString(2);                   
                   // tmpLogInfo.time_Out = reader.GetString(3);
                    tmpLogInfo.biensovao = reader.GetString(4);
                    //  tmpLogInfo.hinhanhvao =  Convert.FromBase64String(reader[]);
                    tmpLogInfo.anhvao = (byte[])reader.GetValue(6);
                    //Convert.FromBase64String(reader.GetString(6));
                    //   tmpLogInfo.biensora = reader.GetString(5);
                    //tmpLogInfo.biensora = strData;

                    // tmpLogInfo.hinhanhvao = (Byte[])(reader.GetValue(6));
                    result.Add(tmpLogInfo);
                }
                dongketnoi();
            }
            catch (Exception e)
            {
                dongketnoi();
            }
            return result;
        }
        // get by time
        public List<LogInfo> GetByTime(int TimeIn, int TimeOut)
        {
            List<LogInfo> result = new List<LogInfo>();
            string query = "select idve,thoigianvao,thoigianra,giatien from tbl_log where thoigianvao <= " + TimeIn + " and thoigianra >= " + TimeOut + "";
            try
            {
                openketnoi();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                // loi get du lieu 
                while (reader.Read())
                {
                    var tmpLogInfo = new LogInfo();
                    tmpLogInfo.idve = reader.GetString(0);
                    tmpLogInfo.time_In = reader.GetString(0);
                    tmpLogInfo.time_Out = reader.GetString(0);

                    //  tmpLogInfo.image_In = Convert.ToInt32(reader.GetValue(4));
                    // tmpLogInfo.image_Out = Convert.ToInt32(reader.GetValue(5));               
                    result.Add(tmpLogInfo);
                }
                dongketnoi();
            }
            catch (Exception e)
            {
                dongketnoi();
            }
            return result;
        }
        // Thêm Log
        public bool addInfoLog(LogInfo logInfo)
        {
            try
            {
                openketnoi();
                string Add = "insert into tbl_Log(id,idthe,thoigianvao,biensovao,hinhanhvao,type) " +
                    "values(" +
                    "NEWID()," +
                    "'" + logInfo.idve + "'," +
                    "'" + logInfo.time_In + "'," +
                     "'" + logInfo.biensovao + "',"+
                        "'" + logInfo.hinhanhvao + "'," +
                     "" + logInfo.type + ")";
                SqlCommand cmd = new SqlCommand(Add, con);
                int result = cmd.ExecuteNonQuery();
                dongketnoi();
                if (result == 1)
                {
                    MessageBox.Show("Thêm thông tin log thành công");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm thông tin");
                return false;
            }
        }
        public bool updateInfoLog(LogInfo logInfo)
        {
            try
            {
                openketnoi();
                string update = "update tbl_log " +
                    "set biensora = '"+ logInfo.biensora + "'," +
                     "thoigianra = '" + logInfo.time_Out + "'" +
                    "where id = '"+ logInfo.id + "'";
                //string update = "update tbl_log" +                        
                //            "set biensora ='rtertet'" +
                //           "where id = 'E5C6CD96-215E-4A58-B9A6-CF8076379059'";
                SqlCommand cmd = new SqlCommand(update, con);
                int result = cmd.ExecuteNonQuery();
                dongketnoi();
                if (result == 1)
                {
                    MessageBox.Show("Update log thành công");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi update thông tin");
                return false;
            }
        }
        // Get số lượng log
        public int GetNumberLog()
        {
            try
            {
                openketnoi();
                string Getnumber = "select COUNT(id) as Tong from tbl_Log where biensora is null";
                SqlCommand cmd = new SqlCommand(Getnumber, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int sum = Convert.ToInt32(reader["Tong"]);
                // int result = cmd.ExecuteNonQuery();
                return sum;             
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public int GetNumberTicker(int type)
        {
            try
            {
                openketnoi();
                string Getnumber = "select count(id) as Tong from tbl_log where type = " +type + "";
                SqlCommand cmd = new SqlCommand(Getnumber, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int sum = Convert.ToInt32(reader["Tong"]);
                // int result = cmd.ExecuteNonQuery();
                return sum;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public int GetNumber_Xe(int type)
        {
            try
            {
                openketnoi();
                string Getnumber = "select count(id) as Tong from tbl_log where type = "+type+" and biensora is null";
                SqlCommand cmd = new SqlCommand(Getnumber, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int sum = Convert.ToInt32(reader["Tong"]);
                // int result = cmd.ExecuteNonQuery();
                return sum;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}
