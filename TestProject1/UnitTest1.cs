using NUnit.Framework;
using Lab1;
namespace Lab1;
[TestFixture]
public class LogicTests
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void LuckyNumberTest()
    {

        //Проверка, что число 123321 является счастливым.
        //Сумма первых трех цифр (1 + 2 + 3) равна сумме последних трех (3 + 2 + 1).

        var result = Logic.IsLuckyNumber(123321);
        Assert.AreEqual(true, result);
    }
    [Test]
    public void NotLuckyNumberTest()
    {
        //Проверка, что число 123456 не является счастливым.
        // Сумма первых трех цифр (1 + 2 + 3) не равна сумме последних трех (4 + 5 + 6).
        var result = Logic.IsLuckyNumber(123456);
        Assert.AreEqual(false, result);
    }
    [Test]
    public void EdgeCaseHighestLuckyNumberTest()
    {

        // Проверка, что число 999999 является счастливым.
        // Сумма первых трех цифр (9 + 9 + 9) равна сумме последних трех (9 + 9 + 9).
        var result = Logic.IsLuckyNumber(999999);
        Assert.AreEqual(true, result);
    }
    [Test]
    public void InputTestSixSymbols()
    {

        // Проверка, что введенное число является шестизначным.

        var result = Logic.IsValidSixDigitNumber(123456);
        Assert.AreEqual(true, result);
    }
    [Test]
    public void InputTestNotSixSymbols()
    {

        // Проверка, что введенное число является шестизначным.

        var result = Logic.IsValidSixDigitNumber(55);
        Assert.AreEqual(false, result);
    }
}
