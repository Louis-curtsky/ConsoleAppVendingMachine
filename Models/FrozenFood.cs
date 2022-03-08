using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class FrozenFood: Product
    {
        public float DefrostTimeInMinutes;
        public DateTime ExpiryDate;
    }
}
