using Bank.WebApi.Models;
using NUnit.Framework;

namespace Bank.WebApi.Tests
{
    public class BankAccountTests
    {
        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            account.Debit(debitAmount);
            double actual = account.Balance;
            Assert.That(actual, Is.EqualTo(expected).Within(0.001), "Account not debited correctly");
        }
    }
}
