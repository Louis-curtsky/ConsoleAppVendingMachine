using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppVendingMachine.Models;

namespace ConsoleAppVendingMachine.Services
{
    public class ProductServices
    {
        private static List<Product> storage = new List<Product>();

  

  
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

        public bool SufficientAmountToPurchase(int prodCode, int qtyToBuy, int moneyToBuy)
        {
            VendingMachine amountChk = new VendingMachine();
            bool sufficientMoney = false;
            foreach (Product product in storage)
            {
                if (product.ProdCode.Equals(prodCode))
                {
                    int totalCost = product.UnitCost * qtyToBuy;
                    if (totalCost < moneyToBuy)
                        sufficientMoney = true;
                }
            }
            return sufficientMoney;
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
