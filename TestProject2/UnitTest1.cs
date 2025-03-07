using NUnit.Framework;

namespace program2;

[TestFixture]
public class GradeCounterTests
{
    [Test]
    public void Test_AddGrade()
    {
        GradeCounter counter = new GradeCounter();
        counter.TryAddGrade(5);
        counter.TryAddGrade(5);
        counter.TryAddGrade(4);
        counter.TryAddGrade(3);
        counter.TryAddGrade(2);
        counter.TryAddGrade(2);

        Assert.AreEqual(2, counter.GetCount5());
        Assert.AreEqual(1, counter.GetCount4());
        Assert.AreEqual(1, counter.GetCount3());
        Assert.AreEqual(2, counter.GetCount2());
    }
    [Test]
    public void Test_AddInvalidGrades()
    {
        GradeCounter counter = new GradeCounter();

        // Пробуем добавить некорректные оценки
        Assert.IsFalse(counter.TryAddGrade(6));  // Оценка больше 5
        Assert.IsFalse(counter.TryAddGrade(1));  // Оценка меньше 2
        Assert.IsFalse(counter.TryAddGrade(-1)); // Отрицательная оценка
        Assert.IsFalse(counter.TryAddGrade(0));  // Оценка 0

        // Проверяем, что не добавились некорректные оценки
        Assert.AreEqual(0, counter.GetCount5());
        Assert.AreEqual(0, counter.GetCount4());
        Assert.AreEqual(0, counter.GetCount3());
        Assert.AreEqual(0, counter.GetCount2());
    }

}
