using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {

            TDSDataModel _instance1 = new TDSDataModel(); //Instance / space
            _instance1.setTradeID("0001");
            _instance1.setDate("22/06/2021");
            _instance1.setCurrentTradeValue(0101);
            _instance1.setCounterpartyID("CPI1");
            Console.WriteLine(_instance1.getTradeID());
            Console.WriteLine(_instance1.getDate());
            Console.WriteLine(_instance1.getCurrentTradeValue());
            Console.WriteLine(_instance1.getCounterpartyID());

            RDSDataModel _instance2 = new RDSDataModel(); //Instance / space
            _instance2.setCounterpartyID("CPI1");
            _instance2.setName("Anand");
            Console.WriteLine(_instance2.getCounterpartyID());
            Console.WriteLine(_instance2.getName());
        }
    }
}
