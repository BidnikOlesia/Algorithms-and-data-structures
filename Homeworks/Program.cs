using System;
using System.Collections.Generic;

#region задания
/*
 * 1. Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
 * 2. Написать программу, которая определяет, является ли введенная скобочная последовательность правильной.
     Примеры правильных скобочных выражений: (), ([])(), {}(),([{}]), неправильных — )(, ())({), (, ])}), ([(]) для скобок [, (, {.
     Например: (2+(2*2)) или [2/{5*(4+7)}].
 * 3. *Создать функцию, копирующую односвязный список (то есть создающую в памяти копию односвязного списка без удаления первого списка).
 * 4. *Реализовать алгоритм перевода из инфиксной записи арифметического выражения в постфиксную.
 * 5. Реализовать очередь:
     1. С использованием массива.
     2. *С использованием односвязного списка.
 * 6. ***Реализовать двустороннюю очередь.
 */
#endregion

namespace Homeworks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region task1
            Console.WriteLine("Задание 1");

            int x = 665; 
            Console.WriteLine($"Число в десятичной двоичной системе исчесления: {x}");
            var stack = new Stack<int>();
            while (x > 0)
            {
                stack.Push(x % 2);
                x /= 2;
            }
            Console.Write("Число в десятичной двоичной системе исчесления: ");
            foreach (int i in stack)
                Console.Write(i);
            Console.WriteLine();
            #endregion

            #region task2
            Console.WriteLine("Задание 2");

            Stack<char> stack2 = new Stack<char>();
            string str = "([(])";
            for (int i = 0; i < str.Length; i++)
                if (str[i] == '(')
                    stack2.Push('(');
                else if (str[i] == ')' & stack2.Count > 0)
                    stack2.Pop();

            Console.WriteLine((stack2.Count == 0) ? $"Последовательность {str} верна" : $"Последовательность {str} неверна");
            Console.WriteLine();
            #endregion

            #region task4
            Console.WriteLine("Задание 4");
            string infix = "5*6+(2-9)";
            Postfix.InfixToPostfix(infix);

            #endregion

            #region task5
            Console.WriteLine("Задание 5");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("Элементы очереди:");
            foreach (var row in queue)
                Console.WriteLine(row);

            int firstElement = queue.Dequeue();
            Console.WriteLine($"Извлеченный элемент: {firstElement}");

            Console.WriteLine("Элементы очереди:");
            foreach (var row in queue)
            Console.WriteLine(row);

            #endregion
        }
    }
}
