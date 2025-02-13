namespace Lab1
{
    using System;

    class Program
    {
        static void Main()
        {
            int number;

            while (true)
            {
                Console.Write("Введите шестизначное число: ");

                if (int.TryParse(Console.ReadLine(), out number) && number >= 100000 && number <= 999999)
                    break;

                Console.WriteLine("Ошибка: введите корректное шестизначное число.");
            }

            int firstDigit = number / 100000;         
            int secondDigit = (number / 10000) % 10;
            int thirdDigit = (number / 1000) % 10;
            int fourthDigit = (number / 100) % 10;
            int fifthDigit = (number / 10) % 10;
            int sixthDigit = number % 10;   

            int firstSum = firstDigit + secondDigit + thirdDigit;
            int secondSum = fourthDigit + fifthDigit + sixthDigit;

            if (firstSum == secondSum)
                Console.WriteLine("Число счастливое!");
            else
                Console.WriteLine("Число не является счастливым.");
        }
    }

}
