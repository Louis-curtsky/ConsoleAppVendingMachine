using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppVendingMachine.Models;
using System.Linq;

namespace ConsoleAppVendingMachine.Services
{
    public class VendingMachineService: IVending<Product>
    {
        private static List<Product> storage = new List<Product>();

        public Product CreateAndSave(Product data)
        {
            Product product = null;
            if (data is Snack)
            {
                product = new Snack(
                    ProductSequence.NextProductId(),
                    data.ProdName,
                    data.Quantity,
                    data.UnitCost,
                    (data as Snack).ExpiryDate.ToShortDateString(),
                    (data as Snack).ContainPeanut
                    );
            }
            else if (data is FrozenFood)
            {
                product = new FrozenFood(
                    ProductSequence.NextProductId(),
                    data.ProdName,
                    data.Quantity,
                    data.UnitCost,
                    (data as FrozenFood).DeFrostInMinutes,
                    (data as FrozenFood).ExpiryDate
                    );
            }
            else if (data is Drinks)
            {
                product = new Drinks(
                ProductSequence.NextProductId(),
                data.ProdName,
                data.Quantity,
                data.UnitCost,
                (data as Drinks).Recycle,
                (data as Drinks).Rebate
                );
            }
            storage.Add(product);
            return product;
        }


        public List<Product> FindAll()
        {
            return storage;
        }

        public Product FindById(int prodCode)
        {
            List<Snack> snacks = new List<Snack>();
            List<Drinks> drinks = new List<Drinks>();
            List<FrozenFood> fronzenFood = new List<FrozenFood>();

            //            ProdUtil filter = new ProdUtil();
            foreach (Product product in storage)
            {
                if (product.ProdCode.Equals(prodCode))
                {
                    if (product is Snack)
                    {
                        snacks.Add(product as Snack);
                        return product;
                    }
                    else
                    if (product is Drinks)
                    {
                        drinks.Add(product as Drinks);
                        return product;
                    }
                    else
                    if (product is FrozenFood)
                    {
                        fronzenFood.Add(product as FrozenFood);
                        return product;
                    } 
                }
            }
            return null;
        }// End FindByID

        public Dictionary<int, int> InsertMoney(int[] moneyInserted)
        {
            VendingMachine vendingMachine = new VendingMachine();

            // Obtain valid denonmination from Vending Machine
            int[] denomination = vendingMachine.Denomination;
            Dictionary<int, int> moneyPool = new Dictionary<int, int>() {
                { 1, 0 },
                { 5, 0 },
                { 10, 0 },
                { 20, 0 },
                { 50, 0 },
                { 100, 0 },
                { 500, 0 },
                { 1000, 0 }};
            bool invalidNotes = true;
            for (int i = 0; i < moneyInserted.Length; i++)
            {
                foreach (var key in vendingMachine.Denomination)
                    if (moneyInserted[i] == key)
                    {
                        moneyPool[moneyInserted[i]] += 1;
                        invalidNotes = false;
                    }
            }
            if (!invalidNotes)
            {
                return moneyPool;
            }
            throw new ArgumentException("Invalid Denomination!!!");
        } // End of InsertMoney

        /*
                public Dictionary<int, int> ReturnExcesstMoneyAtEnd
                    (Product data, Dictionary<int, int> moneyBalance, bool endOfTransaction)
        */
        public Dictionary<int, int> ReturnExcesstMoneyAtEnd
            (int totalAmount, int totalToDeduct, bool endOfTransaction)
        {
            Dictionary<int, int> moneyToReturn = new Dictionary<int, int>() {
                { 1000, 0 },
                { 500, 0 },
                { 100, 0 },
                { 50, 0 },
                { 20, 0 },
                { 10, 0 },
                { 5, 0 },
                { 1, 0 }
            };
            VendingMachine vendingMachine = new VendingMachine();
            /*
                        foreach(var (key, value) in moneyBalance)
                        {
                            totalAmount += (key * value);
                        }
                        foreach (Product product in storage)
                        {
                            totalToDeduct += (product.Quantity * product.UnitCost);
                        }
            */
            totalAmount = totalAmount - totalToDeduct;
            foreach (var (key, value) in moneyToReturn.ToList())
            {
                // Assuming maximum user can insert 8430 cash in the machine
                // Thats each denomination can stored up to 3 notes
                if (totalAmount >= key * 3)
                {
                    totalAmount = totalAmount - (key * 3);
                    moneyToReturn[key] = 3;
                }
                else if (totalAmount >= key * 2)
                {
                    totalAmount = totalAmount - (key * 2);
                    moneyToReturn[key] = 2;
                }
                else if (totalAmount >= key)
                {
                    totalAmount = totalAmount - (key);
                    moneyToReturn[key] = 1;
                }
                else
                {
                    //                    totalAmount = totalAmount;
                }

            }

            return moneyToReturn;
        } // End of InsertMoney

        public Product Purchase(Product data, int prodCodeToBuy, Dictionary<int, int> moneyBalance, int qtyToBuy)
        {
            VendingMachine moneyToBuy = new VendingMachine();
            int totalAmount = 0;
            int sufficientAmount = 0;
            foreach (var (key, value) in moneyBalance)
            {
                totalAmount += (key * value);
            };
            sufficientAmount = data.UnitCost * qtyToBuy;
            //           Dictionary<int, int> moneyPool = new Dictionary<int, int>();

            //             sufficientAmount = productBuy.SufficientAmountToPurchase(prodCodeToBuy, qtyToBuy, totalAmount);
            if (totalAmount < sufficientAmount)
            {
                return null;
            }
            else
            {
                if (data.ProdCode.Equals(prodCodeToBuy) && data.Quantity < qtyToBuy)
                    throw new ArgumentException("Insufficient Product Quantity to sell!!!");
            }
            return data;

        }

    }// End of Class
}
