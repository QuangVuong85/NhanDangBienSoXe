using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhậnDiệnBiểnSốXe.Models
{
    interface ITickerInfoBDX
    {
        void UpdateTickerInfo();
    }
    class TickerInfo
    {
        public string tickerId { get; set; }
        public string bienso { get; set; }
        public string username { get; set; }
        public string cmnd { get; set; }
        public int type { get; set; }
        public int isActive { get; set; }
        public string deadline { get; set; }
    }
    class TickerInforManager
    {
        public static TickerInforManager tickerInforManagerInstance;
        private TickerInfo tickerInfo = new TickerInfo();
        private List<ITickersBDX> observers = new List<ITickersBDX>();

        public void addObserver(ITickersBDX tickerControlBDX)
        {
            observers.Add(tickerControlBDX);
        }
        public void removeObserver(ITickersBDX tickerControlBDX)
        {
            observers.Remove(tickerControlBDX);
        }
        public static TickerInforManager getTickerInfoManagerInstance()
        {
            if (tickerInforManagerInstance == null)
            {
                tickerInforManagerInstance = new TickerInforManager();
            }
            return tickerInforManagerInstance;
        }
        public TickerInfo getTickerInfo()
        {
            return tickerInfo;
        }

        public void updateTickerInfo(TickerInfo _tickerInfo)
        {
            this.tickerInfo = _tickerInfo;
            listenChange();
        }
        public void deleteTickerInfo()
        {
            this.tickerInfo = new TickerInfo();
            listenChange();
        }
        public void listenChange()
        {
            foreach (ITickerInfoBDX tickerControlBDX in observers)
            {
                tickerControlBDX.UpdateTickerInfo();
            }
        }
    }
}
