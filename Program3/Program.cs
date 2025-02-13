namespace Program3
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое предложение:");
            string firstSentence = Console.ReadLine();

            Console.WriteLine("Введите второе предложение:");
            string secondSentence = Console.ReadLine();

            string[] firstWords = firstSentence.Split(' ');
            string[] secondWords = secondSentence.Split(' ');

            // Убираем повторяющиеся слова из первого предложения
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
}
