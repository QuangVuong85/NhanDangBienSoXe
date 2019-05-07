using NhậnDiệnBiểnSốXe.DataConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhậnDiệnBiểnSốXe.Models
{
    interface ITickersBDX
    {
        void UpdateListTicker();
    }
    class TickersManager
    {
        public static TickersManager tickersManagerInstance;
        private List<TickerInfo> listTicker = new List<TickerInfo>();
        private List<ITickersBDX> observers = new List<ITickersBDX>();

        public void addObserver(ITickersBDX tickersBDX)
        {
            observers.Add(tickersBDX);
        }

        public void removeObserver(ITickersBDX tickersBDX)
        {
            observers.Remove(tickersBDX);
        }

        public static TickersManager getTickersManagerInstance()
        {
            if (tickersManagerInstance == null)
            {
                tickersManagerInstance = new TickersManager();
                tickersManagerInstance.loadDataLocal();
            }
            return tickersManagerInstance;
        }
        public List<TickerInfo> getListTicker()
        {
            return listTicker;
        }
        public bool addTicker(TickerInfo ticker)
        {
            TickerConnection tickerConnection = new TickerConnection();
            bool result = tickerConnection.addInfoTicker(ticker);
            if (result)
            {
                loadDataLocal();
                return true;
            }
            return false;
        }

        public bool removeTicker(TickerInfo ticker)
        {
            TickerConnection tickerConnection = new TickerConnection();
            bool result = tickerConnection.deleteTicker(ticker);
            if (result)
            {
                loadDataLocal();
                return true;
            }
            return false;
        }

        public bool updateTicker(TickerInfo ticker,String id)
        {

            TickerConnection tickerConnection = new TickerConnection();
            bool result = tickerConnection.updateInfoTicker(ticker,id);
            if (result)
            {
                loadDataLocal();
                return true;
            }
            return false;
        }

        public void updateListTicker(List<TickerInfo> _listTicker)
        {
            this.listTicker = _listTicker;
            loadDataLocal();
        }
        public void deleteListTicker()
        {
            this.listTicker = new List<TickerInfo>();
            loadDataLocal();
        }
        public void listenChange()
        {
            foreach (ITickersBDX tickersBDX in observers)
            {
                tickersBDX.UpdateListTicker();
            }
        }

        public void loadDataLocal()
        {
            TickerConnection tickerConnection = new TickerConnection();
            this.listTicker = tickerConnection.getAllTicker();
            listenChange();
        }
    }
}
