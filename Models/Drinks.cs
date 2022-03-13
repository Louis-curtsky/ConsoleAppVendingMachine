using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    public class Drinks: Product
    {
        public bool Recycle;
        public float Rebate;
        public string Information { get; set; }

        public Drinks(int productId, string prodName, int qty, int unitCost, bool recycle, float rebate)
        : base(productId,
               prodName,
               qty,
               unitCost) 
        {
            this.Recycle = recycle;
            this.Rebate = rebate;
        }

        public Drinks()
        {
        }


        public override string Examine()
        {
            return $"-- Drinks --\nName: {ProdName}\nRecycle: {Recycle}\nRebate: {Rebate}";
        }

        public override string Use()
        {
            return $"-- Usage --: {Information}";
        }

    }
}
