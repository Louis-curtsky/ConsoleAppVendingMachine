using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class Drinks: Product
    {
        public bool Recycle;
        public float Rebate;

        public Drinks(int productId, string prodName, float unitCost, int qty, bool recycle, float rebate)
    : base(productId, prodName, unitCost, qty) 
        {
            Recycle = recycle;
            rebate = 0.00f;
        }

        public override string Examine()
        {
            return $"-- Drinks --\nName: {ProdName}\nInformation: {Information}\nRecycle: {Recycle}\nRebate: {Rebate}";
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
