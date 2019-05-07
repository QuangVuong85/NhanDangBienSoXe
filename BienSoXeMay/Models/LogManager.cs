using NhậnDiệnBiểnSốXe.DataConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhậnDiệnBiểnSốXe.Models
{
    interface ILogsBDX
    {
        void UpdateListLog();
    }
    class LogsManager
    {
        public static LogsManager logsManagerInstance;
        private List<LogInfo> listLog = new List<LogInfo>();
        private List<ILogsBDX> observers = new List<ILogsBDX>();

        public void addObserver(ILogsBDX logsBDX)
        {
            observers.Add(logsBDX);
        }

        public void removeObserver(ILogsBDX logsBDX)
        {
            observers.Remove(logsBDX);
        }

        public static LogsManager getLogsManagerInstance()
        {
            if (logsManagerInstance == null)
            {
                logsManagerInstance = new LogsManager();
                logsManagerInstance.loadDataLocal();
            }
            return logsManagerInstance;
        }
        public List<LogInfo> getListLog()
        {
            return listLog;
        }
        //public void updateListLog(List<LogInfo> _listLog )
        //{
        //    this.listLog = _listLog;
        //    loadDataLocal(_listLog);
        //}
        public void listenChange()
        {
            foreach (ILogsBDX logsBDX in observers)
            {
                logsBDX.UpdateListLog();
            }
        }
        public void loadDataLocal()
        {
            LogConnection logConnection = new LogConnection();
            this.listLog = logConnection.getAllLog();
            listenChange();
        }
    }
}
