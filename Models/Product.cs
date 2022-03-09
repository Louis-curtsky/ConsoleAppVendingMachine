using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    public abstract class Product
    {
        public int ProdCode { get; set; }
        public string ProdName { get; set; }
        public String Information { get; set; }
        public int Quantity { get; set; }
        public float UnitCost { get; set; }
        public string Usage { get; set; }
        public bool Sold { get; set; }

        public Product(int prodCode)
        {
            this.ProdCode = prodCode;
            this.Sold = false;
        }

        public Product(int prodCode, string prodName, int qty) 
            : this(prodCode)
        {
            this.ProdName = prodName;
            this.Quantity = qty;
        }
        public Product(int prodCode, string prodName, int qty, float unitCost) 
            : this(prodCode, prodName, qty)
        {
            UnitCost = unitCost;
        }
        public Product(int prodCode, string prodName, int qty, float unitCost, string usage) 
            : this(prodCode, prodName, qty, unitCost)
        {
            this.Usage = usage;
        }
        public abstract string Examine();

        public abstract string Use();
    }
}
