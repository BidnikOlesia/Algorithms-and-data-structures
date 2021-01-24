using System;
using System.Collections;
using System.Collections.Generic;
namespace Graphs
{
    public class Graph
    {
        public static void PrintVert(int vert, int[,] matrix)
        {
            Console.Write($"Веошина {vert}. Смежна с вершинами: ");
            int vertCount = matrix.GetLength(0);
            for (int i = 0; i < vertCount; i++)
                if (matrix[vert, i] != 0)
                    Console.Write($" {i}");
        }

        /// <summary>
        /// Обход и вывод графа в глубину
        /// </summary>
        /// <param name="matrix">Matrix.</param>
        public static void PrintDeep(int[,] matrix)
        {
            int vertCount = matrix.GetLength(0);
            List<int> vertList = new List<int>();
            Stack<int> vertStack = new Stack<int>();

            for (int i = 0; i < vertCount; i++)
            {
                int vertCurr = i;
                while (true)
                {
                    if (vertList.IndexOf(vertCurr) < 0)
                    {
                        PrintVert(vertCurr, matrix);
                        Console.WriteLine();
                        vertList.Add(vertCurr);

                        for (int j = 0; j < vertCount; j++)
                            if (matrix[vertCurr, j] != 0 && vertList.IndexOf(j) < 0)
                                vertStack.Push(j);
                    }
                    if (vertStack.Count == 0)
                        break;
                    vertCurr = vertStack.Pop();
                }
            }
        }

        /// <summary>
        /// Обход и вывод графа в ширину
        /// </summary>
        /// <param name="matrix">Matrix.</param>
        public static void PrintWidth(int[,] matrix)
        {
            int vertCount = matrix.GetLength(0);

            List<int> vertList = new List<int>();
            Queue<int> vertQueue = new Queue<int>();

            for (int i = 0; i < vertCount; i++)
            {
                int vertCurr = i;
                while (true)
                {
                    if (vertList.IndexOf(vertCurr) < 0)
                    {
                        PrintVert(vertCurr, matrix);
                        Console.WriteLine();
                        vertList.Add(vertCurr);

                        for (int j = 0; j < vertCount; j++)
                            if (matrix[vertCurr, j] != 0 && vertList.IndexOf(j) < 0)
                                vertQueue.Enqueue(j);
                    }
                    if (vertQueue.Count == 0)
                        break;
                    vertCurr = vertQueue.Dequeue();
                }
            }
        }
    }
}
