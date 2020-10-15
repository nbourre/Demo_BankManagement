using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BankManagement.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<BankAccount> Accounts { get; set; } = new List<BankAccount>();

        public override string ToString() => $"{FirstName}, {LastName}";

    }
}
