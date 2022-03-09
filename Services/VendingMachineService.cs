using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppVendingMachine.Models;

namespace ConsoleAppVendingMachine.Services
{
    class VendingMachineService: IVending<Product>
    {
        public bool InsertMoney(int moneyInsert)
        {
            bool validDeno = false;
            VendingMachine[] moneypool = new VendingMachine[];
            List<ProductServices> denomination = new List<ProductServices>();
            for (int i = 0; i < denominations.Length; i++)
            {
                if (moneyInsert == denominations[i])
                {
                    validDeno = true;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Denomination!!!");
                }

            }
            return validDeno;
        }

    }
}
