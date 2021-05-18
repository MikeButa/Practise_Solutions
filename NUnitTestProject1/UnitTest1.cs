using NUnit.Framework;
using AccountTest;

namespace Tests
{
    [TestFixture]
    public class Tester
    {
        private double epsilon = 1e-6;

        [Test]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            Account account = new Account(-20);

            Assert.AreEqual(0, account.OverdraftLimit, epsilon);
        }

        [Test]
        public void DepositAndWithdrawWillNotAcceptNegativeNumbers()
        {
            Account account = new Account(-20);
            var deposited = account.Deposit(-100);
            var withdrawed = account.Withdraw(-100);
            Assert.AreEqual(false, deposited);
            Assert.AreEqual(false, withdrawed);
        }

        [Test]
        public void AccountCannotOverstepItsOverdraftLimit()
        {
            Account account = new Account(-20);
            var deposited = account.Deposit(100);
            var withdrawed = account.Withdraw(150);
            Assert.AreEqual(false, withdrawed);
            Assert.AreEqual(100, account.Balance, epsilon);
        }

        [Test]
        public void DepositOrWithdrawTheCorrectAmount()
        {
            Account account = new Account(-20);
            var deposited = account.Deposit(100);
            Assert.AreEqual(100, account.Balance, epsilon);
            var withdrawed = account.Withdraw(100);
            Assert.AreEqual(0, account.Balance, epsilon);
        }

        [Test]
        public void DepositOrWithdrawTheCorrectResults()
        {
            Account account = new Account(-20);
            var deposited = account.Deposit(100);
            var withdrawed = account.Withdraw(100);
            Assert.AreEqual(true, deposited);
            Assert.AreEqual(true, withdrawed);
        }

        [Test]
        public void TestDeposit()
        {
            // Create a new account and deposit $100
            Account account = new Account(-20); 
            account.Deposit(100.00f);

            // Make sure we have $100
            Assert.AreEqual(100.00f, account.Balance);

            // Deposit $150
            account.Deposit(150.00f);

            // Make sure we have $250
            Assert.AreEqual(250.00f, account.Balance);
        }

        [Test]
        public void TestWithdraw()
        {
            // Create a new account, deposit $250
            Account account = new Account(-20); 
            account.Deposit(250.00f);

            // Withdraw $100
            account.Withdraw(100.00f);

            // See if we have $150 in the account
            Assert.AreEqual(150.00f, account.Balance);
        }
    }
}