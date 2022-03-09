using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleAppVendingMachine.Models
{
    public class Snack : Product
    {
        public DateTime ExpiryDate;
        public override string Examine()
        {
            return $"-- Snack --\n Name: {ProdName}\nExpriry Date: {ExpiryDate}\n";
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
