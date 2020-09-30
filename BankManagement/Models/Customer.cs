using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<BankAccount> Accounts { get; set; }

        public override string ToString() => $"{FirstName}, {LastName}";
    }
}
