using BankManagement.Data;
using BankManagement.Models;
using System;
using System.Windows.Annotations;
using Xunit;

namespace BankTestsXunit
{
    public class BankAccountTests
    {
        [Fact]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Bryan", "Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Bryan", "Walton", beginningBalance);

            // Act and assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [Fact]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 13;
            BankAccount account = new BankAccount("Bryan", "Walton", beginningBalance);

            // Act and assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }


        [Fact]
        public void Constructor_NegativeAmountShouldThrowArgumentOutOfRange_ShouldFail()
        {
            /// TODO : Complétez ce test où on veut que si l'on crée un nouveau compte, 
            /// il devra y avoir un montant supérieur à zéro
           
            // Arrange

            // Act       

            // Assert

        }



    }
}
