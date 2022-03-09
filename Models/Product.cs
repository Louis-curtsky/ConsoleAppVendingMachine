using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Models
{
    public abstract class Product
    {
        public string ProdName { get; set; }
        public String Information { get; set; }
        public int UnitCost { get; set; }
        public int Quantity { get; set; }
        public string Usage { get; set; }
        public bool Sold;

        public abstract string Examine();

        public abstract string Use();
    }
}
