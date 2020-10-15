using BankManagement.Data;
using BankManagement.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankTestsXunit
{
    public class BankAccountDataServiceTests
    {
        private BankAccountDataService _sut;
        private readonly Mock<IDataService<Customer>> _customerMock = new Mock<IDataService<Customer>>();

        
        [Fact]
        public void BankAccountDataService_HasBankAccount_ShouldPass()
        {
            // Arrange
            _customerMock.Setup(x => x.GetAll()).Returns(GetSomeCustomers());
            _sut = new BankAccountDataService(_customerMock.Object.GetAll());

            // Act
            var bankAccounts = _sut.GetAll();

            // Assert
            Assert.NotEmpty(bankAccounts);
        }


        [Fact]
        public void BankAccountDataService_WithoutCustomerInList_ShouldFail()
        {
            // Arrange  
            var customers = new List<Customer>();

            // Act       


            // Assert
            Assert.Throws<ArgumentException>(() => new BankAccountDataService(customers));
        }
        
        [Fact]
        public void BankAccountDataService_NullCustomerList_ShouldFail()
        {
            // Arrange  
            List<Customer> customers = null;
            // Act       


            // Assert
            Assert.Throws<ArgumentNullException>(() => new BankAccountDataService(customers));
        }


        private List<Customer> GetSomeCustomers()
        {
            var result = new List<Customer>
            {
                new Customer { FirstName = "Nicolas", LastName = "Bourré"},
                new Customer { FirstName = "Fred", LastName = "Caillou"},
                new Customer { FirstName = "Gilligan", LastName = "Island"},
            };

            return result;
        }
    }
}
