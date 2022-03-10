using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleAppVendingMachine.Models
{
    public class Snack : Product
    {
        public DateTime ExpiryDate;
        public bool ContainPeanut;

        public Snack(int productId, string prodName, int qty, int unitCost, DateTime expiryDate, bool containPeanut) 
            : base(productId, 
                   prodName, 
                   qty, 
                   unitCost)
        {
            this.ExpiryDate = expiryDate;
            this.ContainPeanut = containPeanut;
        }
        public override string Examine()
        {
            return $"-- Snack --\n Name: {ProdName}\nPeanut: {ContainPeanut}\nExpriry Date: {ExpiryDate}\n";
        }


        public override string Use()
        {
 
            return $"-- Usage --: {Usage}";

        }

    }
}
