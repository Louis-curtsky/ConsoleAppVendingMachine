using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Services
{
    public interface IVending<DataType>
    {
        //Create
        DataType Purchase(DataType data);

        //Read
        List<DataType> FindAll();

        //Update


        //Delete

    }
}
