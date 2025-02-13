namespace program2
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество учеников: ");
            int n = int.Parse(Console.ReadLine());
            int[] grades = new int[n];

            int count5 = 0, count4 = 0, count3 = 0, count2 = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите оценку ученика {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());

                switch (grades[i])
                {
                    case 5: count5++; break;
                    case 4: count4++; break;
                    case 3: count3++; break;
                    case 2: count2++; break;
                    default: Console.WriteLine("Ошибка! Введите оценку от 2 до 5."); i--; break;
                }
            }

            Console.WriteLine($"Количество пятерок: {count5}");
            Console.WriteLine($"Количество четверок: {count4}");
            Console.WriteLine($"Количество троек: {count3}");
            Console.WriteLine($"Количество двоек: {count2}");
        }
    }

}
