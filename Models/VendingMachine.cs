using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class VendingMachine
    {

        readonly int[] denominations = new int[] {1, 5, 10, 20, 50, 100, 500, 1000};
        public Dictionary<int, int> moneyPool = new Dictionary<int, int>()
        { { 1, 0 }, { 5, 0 }, { 10, 0 }, {20, 0 }, { 50, 0 }, {100, 0 }, { 500, 0 }, {1000, 0 } };
        public Dictionary<int, int> MoneyPool
            {
            get { return moneyPool; }
            } 

        public int[] Denomination 
        {
            get; set;
        }
        
        /*
        public VendingMachine[] AddMoney(int moneyInsert)
        {
            
            Dictionary<int, int> moneyPool = new Dictionary<int, int>();
            //            VendingMachine moneyPool = new VendingMachine();
            bool validDenom = InsertMoney(moneyInsert);
            if (validDenom)
            {
               int moneyAdded = moneyPool[moneyInsert]+1;
                moneyPool[moneyAdded] = moneyAdded;
            }
            return moneyPool;
        }
        */
    }
}
