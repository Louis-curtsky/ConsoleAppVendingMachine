using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class Money
    {
        private readonly Money[] denominations = new Money[] { };
        public int AmountPool;
        public int InputAmount;

        public Money[] Denomination 
        { 
            get { return denominations; }
        }

        public int AddMoney(Money[] money)
        {
            int[] validDenomination = new int[] {1, 5, 10, 20, 50, 100, 500, 1000};
            int addtoPool = 0;
            foreach (Money checkDenom in money)
            {
                for (int i = 0; i < validDenomination.Length; i++)
                {
                    if (checkDenom.InputAmount == validDenomination[i])
                    {
                        InputAmount = addtoPool;
                    }
                }
            }
            return addtoPool;
        }
    }
}
