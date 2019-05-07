using NhậnDiệnBiểnSốXe.DataConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhậnDiệnBiểnSốXe.Models
{
    interface IAdminsBDX
    {
        void UpdateListAdmin();
    }
    class AdminsManager
    {
        public static AdminsManager adminsManagerInstance;
        private List<UserInfo> listAdmin = new List<UserInfo>();
        private List<IAdminsBDX> observers = new List<IAdminsBDX>();

        public void addObserver(IAdminsBDX adminsBDX)
        {
            observers.Add(adminsBDX);
        }

        public void removeObserver(IAdminsBDX adminsBDX)
        {
            observers.Remove(adminsBDX);
        }

        public static AdminsManager getAdminsManagerInstance()
        {
            if (adminsManagerInstance == null)
            {
                adminsManagerInstance = new AdminsManager();
                adminsManagerInstance.loadDataLocal();
            }
            return adminsManagerInstance;
        }
        public List<UserInfo> getListAdmin()
        {
            return listAdmin;
        }
        public bool addAdmin(UserInfo admin, string password)
        {
            UserConnection userConnection = new UserConnection();
            bool result = userConnection.addUser(admin, password);
            if (result)
            {
                loadDataLocal();
                return true;
            }
            return false;
        }

        public bool removeAdmin(UserInfo admin)
        {
            UserConnection userConnection = new UserConnection();
            bool result = userConnection.deleteUser(admin);
            if (result)
            {
                loadDataLocal();
                return true;
            }
            return false;
        }

        public bool updateAdmin(UserInfo admin, string password)
        {

            UserConnection userConnection = new UserConnection();
            bool result = userConnection.updateUser(admin, password);
            if (result)
            {
                loadDataLocal();
                return true;
            }
            return false;
        }

        public void updateListAdmin(List<UserInfo> _listAdmin)
        {
            this.listAdmin = _listAdmin;
            loadDataLocal();
        }
        public void deleteListAdmin()
        {
            this.listAdmin = new List<UserInfo>();
            loadDataLocal();
        }
        public void listenChange()
        {
            foreach (IAdminsBDX adminsBDX in observers)
            {
                adminsBDX.UpdateListAdmin();
            }
        }

        public void loadDataLocal()
        {
            UserConnection userConnection = new UserConnection();
            this.listAdmin = userConnection.getAllAdmin();
            listenChange();
        }
    }
}
