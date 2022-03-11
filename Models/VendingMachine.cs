using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class VendingMachine
    {

        readonly int[] denominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

//        public Dictionary<int, int> moneyPool = new Dictionary<int, int>()
//        { { 1, 0 }, { 5, 0 }, { 10, 0 }, {20, 0 }, { 50, 0 }, {100, 0 }, { 500, 0 }, {1000, 0 } };

 
        public int MoneyInserted{ get; set; }
        public int[] Denomination 
        {
            get { return denominations; }
        }

        public bool EndOfTranscation { get; set; }
        public int ProdCodeToBuy 
        {
            get; set; 
        
        }

        public int qtyToBuy;
        public int QtyToBuy
        {
            get { return qtyToBuy; }
            set
            {
                if (!qtyToBuy.Equals(null) || qtyToBuy >0)
                {
                    qtyToBuy = value;
                }
                else
                {
                    throw new ArgumentException("Quantity input error!!!");
                }
            }
        }
        public int validAmountToBuy;
        public int ValidAmountToBuy { get; set; }
        
        public VendingMachine()
        { }

        public VendingMachine(int proCodeToBuy, int qtyToBuy): this()
        {
            this.QtyToBuy = qtyToBuy;
        }

        public VendingMachine(int proCodeToBuy, int qtyToBuy, int moneyInserted): this(proCodeToBuy, qtyToBuy)
        {
            this.MoneyInserted = moneyInserted;

        }
        
        public VendingMachine(int proCodeToBuy, int qtyToBuy, int moneyInserted, bool endOfTransaction): this(proCodeToBuy, qtyToBuy, moneyInserted)
        {

            this.EndOfTranscation = endOfTransaction;
        }
/*
        public int InsertMoney(int moneyInserted)
        {
            bool invalidNotes = true;
            for (int i = 0; i < Denomination.Length; i++)
            {
                if (moneyInserted == Denomination[i])
                {
                    MoneyPool[moneyInserted] += 1;
                    invalidNotes = false;
                }
                validAmountToBuy = MoneyPool[moneyInserted] * moneyInserted; 
            }
            if (!invalidNotes)
            {
                return validAmountToBuy;
            }
                throw new ArgumentException("Invalid Denomination!!!");
        }
*/
    }
}
