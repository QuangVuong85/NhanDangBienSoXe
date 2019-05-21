using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NhậnDiệnBiểnSốXe.Models
{
    interface ILogInfoBDX
    {
        void UpdateLogInfo();
    }
    class LogInfo
    {
        public string id { get; set; }
        public string idve { get; set; }
        public string time_In { get; set; }
        public string time_Out { get; set; }
        public string biensovao { get; set; }
        public string biensora { get; set; }
        public string hinhanhvao { get; set;}
        public byte[] anhvao { get; set; }
        public int type { get; set; }
    }
    class LogInfoManager
    {
        public static LogInfoManager logInforManagerInstance;
        private LogInfo logInfo = new LogInfo();
        private List<ILogsBDX> observers = new List<ILogsBDX>();

        public void addObserver(ILogsBDX logControlBDX)
        {
            observers.Add(logControlBDX);
        }
        public void removeObserver(ILogsBDX logControlBDX)
        {
            observers.Remove(logControlBDX);
        }
        public static LogInfoManager getLogInfoManagerInstance()
        {
            if (logInforManagerInstance == null)
            {
                logInforManagerInstance = new LogInfoManager();
            }
            return logInforManagerInstance;
        }
        public LogInfo getLogInfo()
        {
            return logInfo;
        }
    }
}
