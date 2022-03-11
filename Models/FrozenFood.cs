using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class FrozenFood: Product
    {
        public float DeFrostInMinutes;
        public DateTime ExpiryDate;
        public string Information { get; set; }

        public FrozenFood(int productId, string prodName, int qty, int unitCost, float deFrostInMinute, DateTime expiryDate)
        : base(productId,
               prodName,
               qty,
               unitCost)
        {
            ExpiryDate = expiryDate;
            DeFrostInMinutes = deFrostInMinute; 
        }
        public override string Examine()
        {
            return $"-- Frozen Food --\nName: {ProdName}\nExpiry Date: {ExpiryDate}\nDefrost Time in Minutes: {DeFrostInMinutes}";
        }

        public override string Use()
        {
                return $"-- Usage --: {Information}";
        }
    }
}
