using System;
namespace Homeworks
{
    public class Methods
    {

        /// <summary>
        /// Получение значения от пользователя
        /// </summary>
        /// <returns>The value.</returns>
        /// <param name="message">Message.</param>
        public static int GetValue(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine());
            return value;
        }


        /// <summary>
        /// Метод, определяющий к какому времени года относится месяц
        /// </summary>
        public static void GetSeasons()
        {
            int month = GetValue("Введите номер месяца");
            string season = string.Empty;
            switch (month)
            {
                case 12:
                case 1:
                case 2: season = "зима";
                        break;

                case 3:
                case 4:
                case 5: season = "весна";
                        break;

                case 6:
                case 7:
                case 8: season = "лето";
                        break;

                case 9:
                case 10:
                case 11:season = "осень";
                        break;
            }
            Console.WriteLine(season);
        }

        /// <summary>
        /// Метод, выводящий возраст с последующим словом «год», «года» или «лет».
        /// </summary>
        public static void GetAge()
        {
            int age = GetValue("Введите возраст человека(от 1 до 150 лет)");
            if (age % 10 == 1 && age != 11)
                Console.WriteLine($"{age} год");
            else if(age%10>1 && age % 10<5)
                Console.WriteLine($"{age} года");
            else
                Console.WriteLine($"{age} лет");

        }

        /// <summary>
        /// Метод, определяющий относятся ли к поля к одному цвету
        /// </summary>
        public static void IsSameColour()
        {
            int x1 = GetValue("Введите значение x1");
            int y1 = GetValue("Введите значение y1");
            int x2 = GetValue("Введите значение x2");
            int y2 = GetValue("Введите значение y2");

            if ((x1 + y1) % 2 == (x2 + y2) % 2)
                Console.WriteLine("Поля относятся к одному цвету");
            else
                Console.WriteLine("Поля не относятся к одному цвету");
        }


        /// <summary>
        /// Метод, выводящий квадраты и кубы чисел от a до b.
        /// </summary>
            public static void GetSquareFromAtoB()
        {
            int a = GetValue("Введите значение числа a");
            int b = GetValue("Введите значение числа b");

            for (int i = a; i < b; i++)
            {
                Console.WriteLine($"Квадрат числа {i} равен {i*i}"); 
                Console.WriteLine($"Куб числа {i} равен {i * i*i}");
            }
        }

        /// <summary>
        /// Метод, находящий  частное от деления нацело N на K, а также остаток от этого деления
        /// </summary>
        public static void GetDivisionResult()
        {
            int n = GetValue("Введите число N");
            int k = GetValue("Введите число K");

            int quotient = 0;


            while (n > k)
            {
                n -= k;
                quotient++;
            }
            Console.WriteLine($"Частное от деления равно {quotient}");
            Console.WriteLine($"Остаток от деления равен {n}");

        }

        /// <summary>
        /// Метод, проверяющий имеются ли в записи числа N нечетные цифры
        /// </summary>
        public static void GetOddDigit()
        {
            bool hasOddDigit = false;
            int digit;
            int number = GetValue("Введите число");
            while (number > 0)
            {
                digit = number % 10;
                if (digit % 2 != 0)
                {
                    hasOddDigit = true;
                    break;
                }
                else
                    number = number / 10;
            }
            Console.WriteLine(hasOddDigit);
        }


        /// <summary>
        /// Метод, подсчитывающий cреднее арифметическое всех положительных четных чисел, оканчивающихся на 8
        /// </summary>
        /// <returns>The avg.</returns>
        public static void GetAvg()
        {
            int sum = 0;
            int count = 0;
            int number;
            do
            {
                Console.WriteLine("Введите чило. Для окончания ввода введите '0')");
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number % 2 == 0 && number % 10 == 8)
                {
                    sum += number;
                    count++;
                }

            }
            while (number != 0);
            Console.WriteLine($"среднее арифметическое всех положительных четных чисел, оканчивающихся на 8 равно {sum/count}");
        }

       

        /// <summary>
        /// Метод, находящий максимальное из трех чисел
        /// </summary>
        public static void GetMax()
        {
            int a = GetValue("Введите значение числа a");
            int b = GetValue("Введите значение числа b");
            int c = GetValue("Введите значение числа c");
            int max;
            if (a > b)
            {
                if (a > c)
                    max = a;
                else
                    max = c;
            }
            else
            {
                if (b > c)
                    max = b;
                else max = c;
            }
            Console.WriteLine($"Максимальное число: {max}");
        }


        /// <summary>
        /// Метод, выводящий на экран все автоморфные числа, не превосходящие N
        /// </summary>
        public static void GetAutomorpNumber()
        {
            int number = GetValue("Введите число");
            int n = 1;
            int reminder;
            int sqr;

            while (n < number)
            {
                int tens = 0;
                int divider = 1;
                int temp = n;
                while (temp > 0)
                {
                    temp /= 10;
                    tens++;
                }
                sqr = n * n;
                for (int i = 0; i < tens; i++)
                {
                    divider *= 10;
                }
                reminder = sqr % divider;
                if (reminder == n)
                    Console.WriteLine($"Число {n} является автоморфным. Квадрат равен {sqr}");
                n++;
            }
        }
       
    }
}
