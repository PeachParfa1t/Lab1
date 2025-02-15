
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
            SentenceChecker.CheckWords("кот собака", "собака лиса");
            string result = output.ToString();
            Assert.IsTrue(result.Contains("—лово 'собака' есть во втором предложении."));
            Assert.IsTrue(result.Contains("—лова 'кот' нет во втором предложении."));
        }

        [Test]
        public void NoWordsExistInSecondSentence()
        {
            SentenceChecker.CheckWords("€блоко груша", "апельсин банан");
            string result = output.ToString();
            Assert.IsTrue(result.Contains("—лова '€блоко' нет во втором предложении."));
            Assert.IsTrue(result.Contains("—лова 'груша' нет во втором предложении."));
        }

        [Test]
        public void AllWordsExistInSecondSentence()
        {
            SentenceChecker.CheckWords("м€ч книга", "м€ч книга тетрадь");
            string result = output.ToString();
            Assert.IsTrue(result.Contains("—лово 'м€ч' есть во втором предложении."));
            Assert.IsTrue(result.Contains("—лово 'книга' есть во втором предложении."));
        }
    }
}