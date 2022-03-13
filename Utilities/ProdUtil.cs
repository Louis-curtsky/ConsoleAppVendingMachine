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
        }// End of Filter Snacks

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
        }// End of Filter Drinks
        public static List<FrozenFood> FilterToOnlyFrozenFood(List<Product> products)
        {
            List<FrozenFood> frozenFoods = new List<FrozenFood>();
            FrozenFood information = new FrozenFood();
            foreach (Product product in products)
            {
                if (product is FrozenFood)
                {
                    frozenFoods.Add(product as FrozenFood);
                    information.Information = information.Examine();
                }
                return frozenFoods;
            }
            return null;
        }// End of Filter Frozen Food

    }
}
