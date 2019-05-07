using NhậnDiệnBiểnSốXe.Constants;
using NhậnDiệnBiểnSốXe.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

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
            string query = "select id,thoigianvao,thoigianra,hinhanhvao,hinhanhra from tbl_log";
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
                    tmpLogInfo.time_In = Convert.ToInt32(reader.GetValue(1));
                    tmpLogInfo.time_Out = Convert.ToInt32(reader.GetValue(2));
                    tmpLogInfo.rate = Convert.ToInt32(reader.GetValue(3));
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
    }
}
