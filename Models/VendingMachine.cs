using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class VendingMachine
    {

        readonly int[] denominations = new int[] {1, 5, 10, 20, 50, 100, 500, 1000};
        public Dictionary<int, int> MoneyPool = new Dictionary<int, int>()
        { { 1, 0 }, { 5, 0 }, { 10, 0 }, {20, 0 }, { 50, 0 }, {100, 0 }, { 500, 0 }, {1000, 0 } };
 

        public int[] Denomination 
        {
            get; set;
        }

        public VendingMachine[] AddMoney(int moneyInsert)
        {
            
            Dictionary<int, int> moneyPool = new Dictionary<int, int>();
            //            VendingMachine moneyPool = new VendingMachine();
            bool validDenom = InsertMoney(moneyInsert);
            if (validDenom)
            {
               int moneyAdded = moneyPool[moneyInsert]+1;                
               MoneyPool = moneyPool;
            }
            return MoneyPool;
        }
        public bool InsertMoney(int moneyInsert)
        {
            bool validDeno = false;
            VendingMachine[] moneypool= new VendingMachine[denominations.Length];
            List<VendingMachine> denomination = new List<VendingMachine>();
            for (int i=0; i<denominations.Length; i++)
            {
                if (moneyInsert == denominations[i])
                {
                    validDeno = true;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Denomination!!!");
                }

            }
            return validDeno;
        }
    }
}
