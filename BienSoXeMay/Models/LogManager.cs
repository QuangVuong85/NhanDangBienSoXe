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
       // private int numberLog;
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
        public bool addLog(LogInfo log)
        {
            LogConnection logConnection = new LogConnection();
            bool result = logConnection.addInfoLog(log);
            if (result)
            {
                loadDataLocal();
                return true;
            }
            return false;
        }
        public bool updateLog(LogInfo log)
        {
            LogConnection logConnection = new LogConnection();
            bool result = logConnection.updateInfoLog(log);
            if (result)
            {
                loadDataLocal();
                return true;
            }
            return false;
        }
        public LogInfo GetLogInfoByIdCard(string idCard)
        {
            foreach (LogInfo tk in this.listLog)
            {
                if (tk.idve == idCard && tk.biensora == null)
                {
                    return tk;
                }
            }
            return null;
        }
        public int getNumberLog()
        {
            LogConnection logConnection = new LogConnection();

            return logConnection.GetNumberLog(); ;
        }
        public int getNumberTicker(int type)
        {
            LogConnection logConnection = new LogConnection();

            return logConnection.GetNumberTicker(type);
        }
        public int getNumber_Xe(int type)
        {
            LogConnection logConnection = new LogConnection();

            return logConnection.GetNumber_Xe(type);
        }
       
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
