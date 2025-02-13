using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Lab1.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void LuckyNumberTest()
        {
            // Проверка счастливого числа
            Assert.IsTrue(Logic.IsLuckyNumber(123321));
        }

        [TestMethod]
        public void NotLuckyNumberTest()
        {
            // Проверка несчастливого числа
            Assert.IsFalse(Logic.IsLuckyNumber(123456));
        }

        [TestMethod]
        public void LuckyNumberWithZerosTest()
        {
            // Проверка числа с нулями
            Assert.IsTrue(Logic.IsLuckyNumber(100001));
        }

        [TestMethod]
        public void EdgeCaseLowestLuckyNumberTest()
        {
            // Проверка наименьшего счастливого числа
            Assert.IsTrue(Logic.IsLuckyNumber(000000));
        }

        [TestMethod]
        public void EdgeCaseHighestLuckyNumberTest()
        {
            // Проверка наибольшего счастливого числа
            Assert.IsTrue(Logic.IsLuckyNumber(999999));
        }
    }
}
