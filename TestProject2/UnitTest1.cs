using NUnit.Framework;

namespace program2;

[TestFixture]
public class GradeCounterTests
{
    private GradeCounter _gradeCounter;

    [SetUp]
    public void Setup()
    {
        _gradeCounter = new GradeCounter();
    }

    [Test]
    public void ProcessGrade_WhenCalledWith5_IncrementsCount5()
    {
        _gradeCounter.ProcessGrade(5);
        Assert.AreEqual(1, _gradeCounter.Count5);
    }

    [Test]
    public void ProcessGrade_WhenCalledWith4_IncrementsCount4()
    {
        _gradeCounter.ProcessGrade(4);
        Assert.AreEqual(1, _gradeCounter.Count4);
    }

    [Test]
    public void ProcessGrade_WhenCalledWith3_IncrementsCount3()
    {
        _gradeCounter.ProcessGrade(3);
        Assert.AreEqual(1, _gradeCounter.Count3);
    }

    [Test]
    public void ProcessGrade_WhenCalledWith2_IncrementsCount2()
    {
        _gradeCounter.ProcessGrade(2);
        Assert.AreEqual(1, _gradeCounter.Count2);
    }

    [Test]
    public void ProcessGrade_WhenCalledWithInvalidGrade_ReturnsFalse()
    {
        bool result = _gradeCounter.ProcessGrade(1);
        Assert.IsFalse(result);
    }

    [Test]
    public void ProcessGrade_WhenCalledMultipleTimes_CorrectlyCountsGrades()
    {
        _gradeCounter.ProcessGrade(5);
        _gradeCounter.ProcessGrade(5);
        _gradeCounter.ProcessGrade(4);
        _gradeCounter.ProcessGrade(3);
        _gradeCounter.ProcessGrade(2);
        _gradeCounter.ProcessGrade(2);

        Assert.AreEqual(2, _gradeCounter.Count5);
        Assert.AreEqual(1, _gradeCounter.Count4);
        Assert.AreEqual(1, _gradeCounter.Count3);
        Assert.AreEqual(2, _gradeCounter.Count2);
    }
}
