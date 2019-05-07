using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhậnDiệnBiểnSốXe.Models
{
    interface IUserInfoBDX
    {
        void UpdateUserInfo();
    }
    class UserInfo
    {
        public string userId { get; set; }
        public string userName { get; set; }
        public int role { get; set; }
        public int isActive { get; set; }
        public string strRole { get; set; }
        public string strActive { get; set; }
    }
    class UserInfoManager
    {
        public static UserInfoManager userInfoManagerInstance;
        private UserInfo userInfo = new UserInfo();
        private List<IUserInfoBDX> observers = new List<IUserInfoBDX>();

        public void addObserver(IUserInfoBDX userControlBDX)
        {
            observers.Add(userControlBDX);
        }

        public void removeObserver(IUserInfoBDX userControlBDX)
        {
            observers.Remove(userControlBDX);
        }

        public static UserInfoManager getUserInfoManagerInstance()
        {
            if (userInfoManagerInstance == null)
            {
                userInfoManagerInstance = new UserInfoManager();
            }
            return userInfoManagerInstance;
        }
        public UserInfo getUserInfo()
        {
            return userInfo;
        }

        public void updateUserInfo(UserInfo _userInfo)
        {
            this.userInfo = _userInfo;
            listenChange();
        }
        public void deleteUserInfo()
        {
            this.userInfo = new UserInfo();
            listenChange();
        }
        public void listenChange()
        {
            foreach (IUserInfoBDX userControlBDX in observers)
            {
                userControlBDX.UpdateUserInfo();
            }
        }

    }
}
