namespace program2
{
    using System;

    class GradeCounter
    {
        public int Count5 { get; private set; } = 0;
        public int Count4 { get; private set; } = 0;
        public int Count3 { get; private set; } = 0;
        public int Count2 { get; private set; } = 0;

        public bool ProcessGrade(int grade)
        {
            switch (grade)
            {
                case 5: Count5++; return true;
                case 4: Count4++; return true;
                case 3: Count3++; return true;
                case 2: Count2++; return true;
                default: return false;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество учеников: ");
            int n = int.Parse(Console.ReadLine());
            int[] grades = new int[n];

            GradeCounter gradeCounter = new GradeCounter();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите оценку ученика {i + 1}: ");
                int grade = int.Parse(Console.ReadLine());

                if (!gradeCounter.ProcessGrade(grade))
                {
                    Console.WriteLine("Ошибка! Введите оценку от 2 до 5.");
                    i--;
                }
            }

            Console.WriteLine($"Количество пятерок: {gradeCounter.Count5}");
            Console.WriteLine($"Количество четверок: {gradeCounter.Count4}");
            Console.WriteLine($"Количество троек: {gradeCounter.Count3}");
            Console.WriteLine($"Количество двоек: {gradeCounter.Count2}");
        }
    }



}
