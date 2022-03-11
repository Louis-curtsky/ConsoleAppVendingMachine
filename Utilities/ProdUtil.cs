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
            Snack information = new Snack();
            foreach (Product product in products)
            {
                if (product is Snack)
                {
                    snacks.Add(product as Snack);
                    information.Information = information.Examine();
                }
                return snacks;
            }
            return null;
        }
/*
        public static List<Drinks> FilterToOnlyDrinks(List<Product> products)
        {
            List<Drinks> drinks = new List<Drinks>();
            Drinks information = new Drinks();
            foreach (Product product in products)
            {
                if (product is Drinks)
                {
                    drinks.Add(product as Drinks);
                    information.Information = information.Examine();
                }
                return drinks;                  
            }
            return null;
        }
*/
    }
}
