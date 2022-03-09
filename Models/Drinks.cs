using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    class Drinks: Product
    {
        public bool Recycle;
        public int Rebate;

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
