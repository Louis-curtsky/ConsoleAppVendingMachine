using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Services
{
    public interface IVending<DataType>
    {
        //Create
        DataType CreateAndSave(DataType data);
//        DataType Purchase(DataType data);
        DataType Purchase(DataType data, int prodCodeToBuy, Dictionary<int, int> moneyBalance, int qtyToBuy);
        //Read
        List<DataType> FindAll();
        //       List<DataType> FindById(int prodCode);
        //Update


        //Delete

    }
}
