using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class Money
    {
        private readonly Money[] denominations = new Money[0];
        public int AmountInMachine;

        public Money[] Denomination 
        { 
            get { return denominations; }
        }


    }
}
