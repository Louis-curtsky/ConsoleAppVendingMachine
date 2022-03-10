using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppVendingMachine.Models;

namespace ConsoleAppVendingMachine.Utilities
{
    public class ProdUtil
    {
        public static List<Snack> FilterToOnlySnacks(List<Product> products)
        {
            List<Snack> snacks = new List<Snack>();

            foreach (Product product in products)
            {
                if (product is Snack)
                {
                    snacks.Add(product as Snack);
                }
            }
            return products;
        }

        public static List<Drinks> FilterToOnlyDrinks(List<Product> products)
        {
            List<Drinks> drinks = new List<Drinks>();

            foreach (Product product in products)
            {
                if (product is Drinks)
                {
                    drinks.Add(product as Drinks);
                }
            }
            return products;
        }
    }
}
