using System;
using System.IO;
using Graphs;

#region задания
/*
 * 1. Написать функции, которые считывают матрицу смежности из файла и выводят ее на экран
 * 2. Написать рекурсивную функцию обхода графа в глубину.
 * 3. Написать функцию обхода графа в ширину.
 * 4. *Создать библиотеку функций для работы с графами.
 */
#endregion

namespace Homeworks
{
    class MainClass
    {
        public static int[,] ReadMatrix(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int[,] matrix = new int[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    matrix[i, j] = Convert.ToInt32(temp[j]);
            }
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(String.Format("{0,3}", matrix[i, j]));
                Console.WriteLine();
            }
        }



        public static void Main(string[] args)
        {
            Console.WriteLine("Марица смежности");
            int[,]matrix = ReadMatrix("matrix.txt");
            PrintMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("Обход графа в глубину");
            Graph.PrintDeep(matrix);

            Console.WriteLine("Обход графа в ширину");
            Graph.PrintWidth(matrix);
        }
    }
}
