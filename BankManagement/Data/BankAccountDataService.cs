using BankManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement.Data
{
    class BankAccountDataService : IDataService<BankAccount>
    {
        List<BankAccount> _bankAccounts;

        public BankAccountDataService(IEnumerable<Customer> customers)
        {
            _bankAccounts = new List<BankAccount>();

            Random rnd = new Random();

            foreach (Customer c in customers)
            {
                c.Accounts = new List<BankAccount>();

                var nbAccounts = rnd.Next(1, 4);

                for (int i = 0; i < nbAccounts; i++)
                {
                    var account = new BankAccount { Customer = c, Number = rnd.Next(1000, 10000).ToString(), Balance = rnd.NextDouble() * 1000 };
                    account.Customer = c;
                    c.Accounts.Add(account);
                }
            }
        }

        public IEnumerable<BankAccount> GetAll()
        {
            foreach (BankAccount a in _bankAccounts)
            {
                yield return a;
            }
        }
    }
}
