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
        public string idve { get; set; }
        public int time_In { get; set; }
        public int time_Out { get; set; }
        public int rate { get; set; }
        public Image image_In { get; set; }
        public Image image_Out { get; set; }
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
