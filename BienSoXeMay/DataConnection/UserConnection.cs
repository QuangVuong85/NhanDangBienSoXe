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
    class UserConnection
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

        public UserInfo Login(string username, string password)
        {
            UserInfo userInfo = new UserInfo();
            string query = "select * from tbl_User where username = '" + username + "'";
            try
            {
                openketnoi();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string tmpPass = reader["password"].ToString();
                if (tmpPass != null && tmpPass != "")
                {
                    if (tmpPass == password)
                    {
                        userInfo.userId = reader["id"].ToString();
                        userInfo.userName = username;
                        userInfo.role = int.Parse(reader["role"].ToString());
                        userInfo.isActive = int.Parse(reader["isActive"].ToString());
                        UserInfoManager userInfoManager = UserInfoManager.getUserInfoManagerInstance();
                        userInfoManager.updateUserInfo(userInfo);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác");

                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");

                }
                dongketnoi();
            }
            catch
            {
                dongketnoi();
                MessageBox.Show("Đăng nhập không thành công");
            }
            return userInfo;
        }
        public List<UserInfo> getAllAdmin()
        {
            List<UserInfo> result = new List<UserInfo>();
            string query = "select id,username,role,isActive from tbl_User";
            try
            {
                openketnoi();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                // loi get du lieu 
                while (reader.Read())
                {
                    var tmpUserInfo = new UserInfo();

                    tmpUserInfo.userId = reader.GetString(0);
                    tmpUserInfo.userName = reader.GetString(1);
                    tmpUserInfo.role = Convert.ToInt32(reader.GetValue(2));// reader.GetInt32(reader.GetOrdinal("role"));
                    tmpUserInfo.isActive = Convert.ToInt32(reader.GetValue(3));
                    tmpUserInfo.strRole = "User";
                    if (Convert.ToInt32(reader.GetValue(2)) == 1)
                    {
                        tmpUserInfo.strRole = "Admin";
                    }
                    tmpUserInfo.strActive = "Không hoạt động";
                  
                    if (Convert.ToInt32(reader.GetValue(3)) != 0)
                    {
                        tmpUserInfo.strActive = "Đang Hoạt động";
                    }
                    result.Add(tmpUserInfo);
                }

                dongketnoi();
            }
            catch (Exception e)
            {
                dongketnoi();
            }
            return result;
        }
        public bool addUser(UserInfo userInfo, string password)
        {
            try
            {
                if (CheckNameUser(userInfo.userName) == true)
                {
                    MessageBox.Show("Tên đã tồn tại");
                }
                else
                {
                    openketnoi();
                    string Add = "insert into tbl_User " +
                                  "values (NEWID(),N'" + userInfo.userName + "','" + password + "','" + userInfo.role + "','" + userInfo.isActive + "')";
                    SqlCommand cmd = new SqlCommand(Add, con);
                    int result = cmd.ExecuteNonQuery();
                    dongketnoi();
                    if (result == 1)
                    {
                        MessageBox.Show("Thêm thành công");
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
                MessageBox.Show("Lỗi thêm admin");
                return false;
            }
            return true;
        }
        public bool updateUser(UserInfo userInfo, string password)
        {
            try
            {
                openketnoi();
                string Update = "update tbl_User " +
                    "set username = N'" + userInfo.userName + "', password = '" + password + "', role = '" + userInfo.role + "', isActive = '" + userInfo.isActive + "'" +
                    "where id = '" + userInfo.userId + "'";
                SqlCommand cmd = new SqlCommand(Update, con);
                int result = cmd.ExecuteNonQuery();
                dongketnoi();
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thành công");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật admin");
                return false;
            }


        }
        public bool deleteUser(UserInfo userInfo)
        {
            try
            {
                openketnoi();
                string Delete = "delete tbl_User from tbl_User where id = '" + userInfo.userId + "'";
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
                MessageBox.Show("Lỗi xóa admin");
                return false;
            }


        }
        public static Boolean CheckNameUser(string username)
        {
            openketnoi();
            string checkname = "select username from tbl_User where username = N'" + username + "'";
            SqlCommand cmd = new SqlCommand(checkname, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            try
            {
                if (String.Compare(username, reader["username"].ToString()) == 0)
                {
                    dongketnoi();
                    return true;
                }
                if (username == "")
                {
                    dongketnoi();
                    return false;
                }
            }
            catch
            {
                dongketnoi();
                return false;
            }
            dongketnoi();
            return false;
        }
    }
}
