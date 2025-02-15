
namespace Program3
{

    [TestFixture]
    public class SentenceCheckerTests
    {
        private StringWriter output;

        [SetUp]
        public void Setup()
        {
            output = new StringWriter();
            Console.SetOut(output);
        }

        [TearDown]
        public void TearDown()
        {
            output.Dispose();
        }

        [Test]
        public void WordExistsInSecondSentence()
        {
            SentenceChecker.CheckWords("��� ������", "������ ����");
            string result = output.ToString();
            Assert.IsTrue(result.Contains("����� '������' ���� �� ������ �����������."));
            Assert.IsTrue(result.Contains("����� '���' ��� �� ������ �����������."));
        }

        [Test]
        public void NoWordsExistInSecondSentence()
        {
            SentenceChecker.CheckWords("������ �����", "�������� �����");
            string result = output.ToString();
            Assert.IsTrue(result.Contains("����� '������' ��� �� ������ �����������."));
            Assert.IsTrue(result.Contains("����� '�����' ��� �� ������ �����������."));
        }

        [Test]
        public void AllWordsExistInSecondSentence()
        {
            SentenceChecker.CheckWords("��� �����", "��� ����� �������");
            string result = output.ToString();
            Assert.IsTrue(result.Contains("����� '���' ���� �� ������ �����������."));
            Assert.IsTrue(result.Contains("����� '�����' ���� �� ������ �����������."));
        }
    }
}