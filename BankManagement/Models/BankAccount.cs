using System;

namespace BankManagement.Models
{
    public class BankAccount
    {
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

            Balance += amount; // intentionally incorrect code
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
