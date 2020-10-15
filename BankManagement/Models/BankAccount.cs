using System;

namespace BankManagement.Models
{
    public class BankAccount
    {
        public BankAccount()
        {

        }

        public BankAccount(string firstName, string lastName, double beginningBalance)
        {
            Customer = new Customer { FirstName = firstName, LastName = lastName };
            Customer.Accounts.Add(this);
            Balance = beginningBalance;
        }

        public BankAccount(Customer c, double beginningBalance)
        {
            Balance = beginningBalance;
            Customer = c;
            c.Accounts.Add(this);
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public double Balance { get; set; }


        public Customer Customer { get; set; }


        public override string ToString()
        {
            return $"#{Number} : {Balance:C2}";
        }

        public void Debit(double amount)
        {
            if (amount > Balance || amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Balance += amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            Balance += amount;
        }

    }
}
