using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    #region UserDefined DataTypes
    public class RDSDataModel
    {
        #region state-private
        private string CounterpartyID;
        private string Name;
        #endregion
        #region Behaviors, public interfaces
        public string getCounterpartyID()
        {
            return this.CounterpartyID;
        }
        public string getName()
        {
            return this.Name;
        }
        public void setCounterpartyID(string value)
        {
            this.CounterpartyID = value;
        }
        public void setName(string value)
        {
            this.Name = value;
        }
        #endregion
    }
    #endregion
}
