namespace Lab1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Определить, является ли заданное шестизначное число счастливым.");
            Console.WriteLine("Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр.");

            int number;
            do
            {
                Console.Write("Введите шестизначное число: ");
                string input = Console.ReadLine();
                number = int.TryParse(input, out int result) ? result : -1;
            } while (!Logic.IsValidSixDigitNumber(number));

            if (Logic.IsLuckyNumber(number))
                Console.WriteLine("Число счастливое!");
            else
                Console.WriteLine("Число не является счастливым.");
        }

       
    }

    public class Logic
    {
        public static bool IsValidSixDigitNumber(int number)
        {
            return number >= 100000 && number <= 999999;
        }
        public static bool IsLuckyNumber(int number)
        {
            int firstDigit = number / 100000;
            int secondDigit = (number / 10000) % 10;
            int thirdDigit = (number / 1000) % 10;
            int fourthDigit = (number / 100) % 10;
            int fifthDigit = (number / 10) % 10;
            int sixthDigit = number % 10;

            int firstSum = firstDigit + secondDigit + thirdDigit;
            int secondSum = fourthDigit + fifthDigit + sixthDigit;

            return firstSum == secondSum;
        }
    }
}
