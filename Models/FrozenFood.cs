using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class FrozenFood: Product
    {
        public float DefrostTimeInMinutes;
        public DateTime ExpiryDate;

        public override string Examine()
        {
            return $"-- Frozen Food --\nName: {ProdName}\nInformation: {Information}\nExpiry Date: {ExpiryDate}\nDefrost Time in Minutes: {DefrostTimeInMinutes}";
        }

        public override string Use()
        {
            if (Sold == true)
            {
                return $"-- Usage --: {Information}";
            }
            else
                return null;
        }
    }
}
