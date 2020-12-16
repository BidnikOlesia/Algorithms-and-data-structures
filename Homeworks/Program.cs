﻿using System;

namespace Homeworks
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            #region задание 5
            /*
             * С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.
             */
            Console.WriteLine("Определение времени года");
            Methods.GetSeasons();

            #endregion

            #region задание 6
            /*
             * Ввести возраст человека(от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».
             */
            Console.WriteLine("Вывод правльного склонения возраста");
            Methods.GetAge();

            #endregion


            #region задание 7
            /*
             * С клавиатуры вводятся числовые координаты двух полей шахматной доски (x1,y1,x2,y2). Требуется определить, относятся ли к поля к одному цвету или нет.
             */
            Console.WriteLine("Определние, относятся ли к поля к одному цвету");
            Methods.IsSameColour();

            #endregion

            #region задание 8
            /*
             * Ввести a и b и вывести квадраты и кубы чисел от a до b.
             */
            Console.WriteLine("Вывод квадратов и кубов чисел от a до b");
            Methods.GetSquareFromAtoB();

            #endregion

            #region задание 9
            /*
             * Даны целые положительные числа N и K. Используя только операции сложения и вычитания, найти частное от деления нацело N на K, 
             * а также остаток от этого деления.
             */
            Console.WriteLine("Вывод частного  от деления нацело N на K, а также остаток от этого деления.");
            Methods.GetDivisionResult();

            #endregion


            #region задание 10
            /*
             * Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить,имеются ли в записи числа N нечетные цифры. 
             * Если имеются, то вывести True, если нет — вывести False.
             */
            Console.WriteLine("Определение, имеются ли в записи числа N нечетные цифры");
            Methods.GetOddDigit();

            #endregion

            #region задание 11
            /*
             * С клавиатуры вводятся числа, пока не будет введен 0. 
             * Подсчитать среднее арифметическое всех положительных четных чисел, оканчивающихся на 8.
             */
            Console.WriteLine("Подсчет среднего арифметического всех положительных четных чисел, оканчивающихся на 8");
            Methods.GetAvg();

            #endregion

            #region задание 12
            /*
             * Написать функцию нахождения максимального из трех чисел.
             */
            Console.WriteLine("Нахождение максимального из трех чисел");
            Methods.GetMax();

            #endregion

            #region задание 14
            /*
             * Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата. 
             * Напишите программу, которая вводит натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.
             */
            Console.WriteLine("Вывод на экран всех автоморфных чисел, не превосходящих N");
            Methods.GetAutomorpNumber();

            #endregion

        }
    }
}



