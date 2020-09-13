using NUnit.Framework;
using System;
using Banking_App;

namespace BankingAppTests
{
    [TestFixture]
    public class AccessPageTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnAccountType_accountTypeIs1_ReturnSavings()
        {
            DateTime dateTime = new DateTime(12, 1, 3);
            var accountType = AccessPage.ReturnAccountType("1", "ola", dateTime, "male", "feyisamuel@gmail.com", 1245654312, "passwordwe");

            Assert.That(accountType, Is.TypeOf<Savings>());
        }

        [Test]
        public void ReturnAccountType_AccountTypeIs2_ReturnCurrent()
        {
            DateTime dateTime = new DateTime(12, 1, 3);
            var accountType = AccessPage.ReturnAccountType("2", "ola", dateTime, "male", "feyisamuel@gmail.com", 1245654312, "passwordwe");

            Assert.That(accountType, Is.TypeOf<Current>());
        }

        [Test]
        public void ReturnAccountType_AccountTypeNot1or2_ReturnNull()
        {
            DateTime dateTime = new DateTime(12, 1, 3);
            var accountType = AccessPage.ReturnAccountType("3", "ola", dateTime, "male", "feyisamuel@gmail.com", 1245654312, "passwordwe");

            Assert.That(accountType, Is.Null);
        }
    }
}