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

        //��������, ��� ����� 123321 �������� ����������.
        //����� ������ ���� ���� (1 + 2 + 3) ����� ����� ��������� ���� (3 + 2 + 1).

        var result = Logic.IsLuckyNumber(123321);
        Assert.AreEqual(true, result);
    }
    [Test]
    public void NotLuckyNumberTest()
    {
        //��������, ��� ����� 123456 �� �������� ����������.
        // ����� ������ ���� ���� (1 + 2 + 3) �� ����� ����� ��������� ���� (4 + 5 + 6).
        var result = Logic.IsLuckyNumber(123456);
        Assert.AreEqual(false, result);
    }
    [Test]
    public void EdgeCaseHighestLuckyNumberTest()
    {

        // ��������, ��� ����� 999999 �������� ����������.
        // ����� ������ ���� ���� (9 + 9 + 9) ����� ����� ��������� ���� (9 + 9 + 9).
        var result = Logic.IsLuckyNumber(999999);
        Assert.AreEqual(true, result);
    }
    [Test]
    public void InputTestSixSymbols()
    {

        // ��������, ��� ��������� ����� �������� ������������.

        var result = Logic.IsValidSixDigitNumber(123456);
        Assert.AreEqual(true, result);
    }
    [Test]
    public void InputTestNotSixSymbols()
    {

        // ��������, ��� ��������� ����� �������� ������������.

        var result = Logic.IsValidSixDigitNumber(55);
        Assert.AreEqual(false, result);
    }
}
