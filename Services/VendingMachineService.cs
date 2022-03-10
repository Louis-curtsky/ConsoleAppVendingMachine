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

        public Product Purchase(Product data)
        {
            VendingMachine moneyToBuy = new VendingMachine();
            Dictionary<int, int> moneyPool = new Dictionary<int, int>();
            Product product = null;
            ProductServices productBuy = new ProductServices();

            if (productBuy.SufficientQtyChk(moneyToBuy.ProdCodeToBuy, moneyToBuy.QtyToBuy))
            {
              if (moneyToBuy.ValidAmountToBuy >0)
              {
               product = 
               productBuy.SufficientAmountToPurchase(moneyToBuy.ProdCodeToBuy, moneyToBuy.QtyToBuy, moneyToBuy.ValidAmountToBuy);
              }
            }
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
                    if (product is Snack)                      

                    return product;
                }
            }
            return null;
        }
    }
}
