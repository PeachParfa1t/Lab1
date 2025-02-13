namespace Lab1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Введите шестизначное число: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 100000 && number <= 999999)
            {
                // Разбираем число на цифры
                int firstDigit = number / 100000;         // первая цифра
                int secondDigit = (number / 10000) % 10;  // вторая цифра
                int thirdDigit = (number / 1000) % 10;    // третья цифра
                int fourthDigit = (number / 100) % 10;    // четвёртая цифра
                int fifthDigit = (number / 10) % 10;      // пятая цифра
                int sixthDigit = number % 10;            // шестая цифра

                int firstSum = firstDigit + secondDigit + thirdDigit;
                int secondSum = fourthDigit + fifthDigit + sixthDigit;

                if (firstSum == secondSum)
                    Console.WriteLine("Число счастливое!");
                else
                    Console.WriteLine("Число не является счастливым.");
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное шестизначное число.");
            }
        }
    }
}
