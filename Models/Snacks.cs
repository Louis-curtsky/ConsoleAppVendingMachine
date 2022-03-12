using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleAppVendingMachine.Models
{
    public class Snack : Product
    {
        public DateTime ExpiryDate;
        public bool ContainPeanut;
        public string Information { get; set; }

        public Snack(int productId, string prodName, int qty, int unitCost, string expiryDate, bool containPeanut)
        : base(productId,
                   prodName,
                   qty,
                   unitCost)
        {
            this.ContainPeanut = containPeanut;
            this. ExpiryDate = DateTime.Parse(expiryDate);
        }

        public Snack()
        {
        }

        public Snack(int prodCode): this()
        {
            this.ProdCode = prodCode;
        }
/*
        public Snack(int prodCode, string prodName, int quantity, int unitCost): this(prodCode, prodName, quantity, unitCost)
        {
            this.ProdCode = prodCode;
            this.ProdName = prodName;
            this.Quantity = quantity;
        }
*/
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
