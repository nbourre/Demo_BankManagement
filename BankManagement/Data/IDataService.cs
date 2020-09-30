using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement.Data
{
    public interface IDataService<T>
    {
        public IEnumerable<T> GetAll();
    }
}
