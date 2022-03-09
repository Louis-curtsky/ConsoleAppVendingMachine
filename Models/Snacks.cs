using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleAppVendingMachine.Models
{
    public class Snack : Product
    {
        public DateTime ExpiryDate;
        public bool ContainPeanut;

        public Snack(int productId, string prodName, int qty, float unitCost, string usage, DateTime expiryDate, bool containPeanut) 
            : base(productId, prodName, qty, unitCost, usage)
        {
            ExpiryDate = expiryDate;
            ContainPeanut = containPeanut;
        }
        public override string Examine()
        {
            return $"-- Snack --\n Name: {ProdName}\nPeanut: {ContainPeanut}\nExpriry Date: {ExpiryDate}\n";
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
