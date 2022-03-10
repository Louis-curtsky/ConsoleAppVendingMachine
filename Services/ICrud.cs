using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVendingMachine.Services
{
    public interface ICrud<DataType>
    {
        //Create
        DataType CreateAndSave(DataType data);

        //Read
        DataType FindById(int id);
        List<DataType> FindAll();

        //Update
        bool Update(DataType data);

        //Delete
        bool Delete(int id);
    }
}
