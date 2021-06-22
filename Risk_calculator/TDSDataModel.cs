using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    #region UserDefined DataTypes
    public class TDSDataModel
    {
        #region state-private
        private string TradeID;
        private string Date;
        private int CurrentTradeValue;
        private string CounterpartyID;
        #endregion
        #region Behaviors, public interfaces
        public string getTradeID()
        {
            return this.TradeID;
        }
        public string getDate()
        {
            return this.Date;
        }
        public int getCurrentTradeValue()
        {
            return this.CurrentTradeValue;
        }
        public string getCounterpartyID()
        {
            return this.CounterpartyID;
        }
        public void setTradeID(string value)
        {
            this.TradeID = value;
        }
        public void setDate(string value)
        {
            this.Date = value;
        }
        public void setCurrentTradeValue(int value)
        {
            this.CurrentTradeValue = value;
        }
        public void setCounterpartyID(string value)
        {
            this.CounterpartyID = value;
        }
        #endregion
    }
    #endregion
}
