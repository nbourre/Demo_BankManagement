using BankManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement.Data
{
    public class CustomerDataService : IDataService<Customer>
    {
        List<Customer> _customers;

        public CustomerDataService()
        {
            _customers = new List<Customer>
            {
                new Customer {FirstName = "Nicolas", LastName = "The Tsar", Email = "nthetsar@gmail.com"},
                new Customer {FirstName = "Pablo", LastName = "Escobar", Email = "pablo.escobar@gmail.com"},
                new Customer {FirstName = "Al", LastName = "Capone", Email = "al.capone@gmail.com"}
            };
        }
        public IEnumerable<Customer> GetAll()
        {
            foreach (Customer c in _customers)
            {
                yield return c;
            }
        }
    }
}
