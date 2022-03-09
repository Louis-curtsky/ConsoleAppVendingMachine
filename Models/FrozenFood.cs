using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class FrozenFood: Product
    {
        public float DeFrostInMinutes;
        public DateTime ExpiryDate;

        public FrozenFood(int productId, string prodName,  int qty, float unitCost, string usage, float deFrostInMinute, DateTime expiryDate)
                : base(productId, prodName, qty, unitCost, usage)
        {
            ExpiryDate = expiryDate;
            DeFrostInMinutes = deFrostInMinute; 
        }
        public override string Examine()
        {
            return $"-- Frozen Food --\nName: {ProdName}\nInformation: {Information}\nExpiry Date: {ExpiryDate}\nDefrost Time in Minutes: {DeFrostInMinutes}";
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
