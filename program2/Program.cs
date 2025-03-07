namespace program2
{
    using System;
    public class GradeCounter
    {
        private int count5 = 0; //приватные потому что инкапсуляция 
        private int count4 = 0; //а из-за того что инкапсуляция там дальше методы эддгрейд и геткаунты
        private int count3 = 0;
        private int count2 = 0;

        public bool TryAddGrade(int grade)
        {
            if (grade >= 2 && grade <= 5)  // Проверка на допустимость оценки
            {
                switch (grade)
                {
                    case 5:
                        count5++;
                        break;
                    case 4:
                        count4++;
                        break;
                    case 3:
                        count3++;
                        break;
                    case 2:
                        count2++;
                        break;
                }
                return true; 
            }
            return false; 
        }

        public int GetCount5() { return count5; } //решена проблема смешанной логики м взаимодействия с пользоватлем
        public int GetCount4() { return count4; }
        public int GetCount3() { return count3; }
        public int GetCount2() { return count2; }
    }

    class Program
    {
        static void Main()
        {
            GradeCounter counter = new GradeCounter();

            Console.WriteLine("Введите количество учеников:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Введите положительное целое число.");
            }

            for (int i = 0; i < n; i++)
            {
                int grade;
                Console.WriteLine("Введите оценку ученика (2-5):");

                // Здесь больше нет проверки на диапазон, она теперь в TryAddGrade
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out grade) && counter.TryAddGrade(grade))
                    {
                        break;  // Оценка успешно добавлена
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите число от 2 до 5.");
                    }
                }
            }

            // Вывод результатов
            Console.WriteLine("Количество пятерок: " + counter.GetCount5());
            Console.WriteLine("Количество четверок: " + counter.GetCount4());
            Console.WriteLine("Количество троек: " + counter.GetCount3());
            Console.WriteLine("Количество двоек: " + counter.GetCount2());
        }
    }

}
