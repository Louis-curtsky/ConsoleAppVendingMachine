using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppVendingMachine.Models;

namespace ConsoleAppVendingMachine.Services
{
    public class ProductServices : ICrud<Product>
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
                    data.Usage,
                    (data as Snack).ExpiryDate,
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
                    data.Usage,
                    (data as FrozenFood).DeFrostInMinutes,
                    (data as FrozenFood).ExpiryDate
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
            foreach (Product product in storage)
            {
                if (product.ProdCode.Equals(prodCode))
                {
                    return product;
                }
            }
            return null;
        }

        public bool SufficientQtyChk(int prodCode, int qtyToBuy)
        {
            bool suffcientQty = false;
            foreach (Product product in storage)
            {
                if (product.ProdCode.Equals(prodCode) && product.Quantity >= qtyToBuy)
                {
                    suffcientQty = true;
                }
            }
            return suffcientQty;
        }

        public Product SufficientAmountToPurchase(int prodCode, int qtyToBuy, int moneyToBuy)
        {
            VendingMachine amountChk = new VendingMachine();
            int totalCost = 0;
            foreach (Product product in storage)
            {
                if (product.ProdCode.Equals(prodCode))
                {
                    totalCost = product.UnitCost * qtyToBuy;
                    if (totalCost < moneyToBuy)
                        return product;
                }
            }
            return null;
        }
        public bool Update(Product data)
        {
            for (int i = 0; i < storage.Count; i++)
            {
                if (storage[i].ProdCode.Equals(data.ProdCode))
                {
                    storage[i] = data;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(int id)
        {
            return storage.Remove(FindById(id));
        }

    }
}
