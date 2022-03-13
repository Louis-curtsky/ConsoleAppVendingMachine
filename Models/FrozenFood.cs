using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    public class FrozenFood: Product
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
            this.ExpiryDate = expiryDate;
            this.DeFrostInMinutes = deFrostInMinute; 
        }

        public FrozenFood() 
        { }
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
