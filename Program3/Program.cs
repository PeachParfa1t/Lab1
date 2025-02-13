namespace Program3
{
    using System;
    using System.Linq;

    class SentenceChecker
    {
        public static void CheckWords(string firstSentence, string secondSentence)
        {
            string[] firstWords = firstSentence.Split(' ');
            string[] secondWords = secondSentence.Split(' ');
            string[] uniqueFirstWords = firstWords.Distinct().ToArray();

            Console.WriteLine("Результат:");
            foreach (string word in uniqueFirstWords)
            {
                if (secondWords.Contains(word))
                {
                    Console.WriteLine($"Слово '{word}' есть во втором предложении.");
                }
                else
                {
                    Console.WriteLine($"Слова '{word}' нет во втором предложении.");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Даны два предложения.");
            Console.WriteLine(".Для каждого слова первого предложения определить, входит ли оно во второе предложение.");
            Console.WriteLine("Повторяющиеся слова первого предложения не рассматривать.");
            Console.WriteLine("Введите первое предложение:");
            string firstSentence = Console.ReadLine();

            Console.WriteLine("Введите второе предложение:");
            string secondSentence = Console.ReadLine();

            SentenceChecker.CheckWords(firstSentence, secondSentence);
        }
    }
}
