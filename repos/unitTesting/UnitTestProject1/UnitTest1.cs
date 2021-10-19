using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using unitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestBankAccount
    {
        [TestMethod]
        public void TestDebit()
        {
            // Arrange
            double beginningBalance = 30.0;
            double debitAmount = 7.5;
            double expected = 22.5;
            BankAccount account = new BankAccount("Mr. dror lev", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");

        }
    }
}
