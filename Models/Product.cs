using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    public abstract class Product
    {
        public int ProdCode { get; set; }
        public string ProdName { get; set; }
        public int Quantity { get; set; }
        public int UnitCost { get; set; }
        public string Usage { get; set; }


        public Product(int prodCode)
        {
            this.ProdCode = prodCode;
        }

        public Product(int prodCode, string prodName, int qty) 
            : this(prodCode)
        {
            this.ProdName = prodName;
            this.Quantity = qty;
        }
        public Product(int prodCode, string prodName, int qty, int unitCost) 
            : this(prodCode, prodName, qty)
        {
            UnitCost = unitCost;
        }
        public Product(int prodCode, string prodName, string information, int qty, int unitCost, string usage) 
            : this(prodCode, prodName, qty, unitCost)
        {
            this.Usage = usage;

        }
        public abstract string Examine();

        public abstract string Use();
    }
}
