using System;
using System.IO;
using System.Collections.Generic;
namespace Homeworks
{
    public class Arrays
    {
        public static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }


        /// <summary>
        /// Метод пузырьковой сортировки
        /// </summary>
        /// <returns>The sort.</returns>
        /// <param name="array">Array.</param>
        /// <param name="swaps">Количество операций</param>
        public static int[] BubbleSort(int[] array, out int swaps)
        {
            swaps = 0;
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    swaps++;
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swaps++;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Метод 'оптимизированной' пузырьковой сортировки
        /// </summary>
        /// <returns>The sort2.</returns>
        /// <param name="array">Array.</param>
        /// <param name="swaps">Swaps.</param>
        public static int[] BubbleSort2(int[] array, out int swaps)
        {
            swaps = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    swaps++;
                    if (array[i] >array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                        swaps++;
                    }
                }
            }
            return array;
        }


        /// <summary>
        /// Метод шейкерной сортировки массива
        /// </summary>
        /// <returns>The sort.</returns>
        /// <param name="array">Array.</param>
        /// <param name="swaps">количество операций</param>
        public static int[] ShakerSort(int[] array, out int swaps)
        {
            swaps = 0;

            for (int i = 0; i < array.Length / 2; i++)
            {
                bool swapFlag = false;
                swaps++;
                for (int j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                        swaps++;
                    }
                }

                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                        swaps++;
                    }
                }
                if (!swapFlag)
                    break;
            }
            return array;
        }
        


        /// <summary>
        /// Метод бинарного поиска в массиве
        /// </summary>
        /// <returns>The search.</returns>
        /// <param name="value">Value.</param>
        /// <param name="array">Array.</param>
        public static int Search(int value, int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (value == array[middle])
                    return middle;
                else if (value < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }

        /// <summary>
        /// Метод создание и записи массива с заданным количеством элементов в файл
        /// </summary>
        /// <param name="arrayLength">Array length.</param>
        public static void WriteArray(int arrayLength)
        {
            string filepath = "array.txt";
            int[] array = new int[arrayLength];
            Random rnd = new Random();

            using (StreamWriter sw = new StreamWriter(filepath, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    array[i] = rnd.Next(0, 100);
                    sw.Write($"{array[i]} ");
                }
            }
        }

        /// <summary>
        /// Метод чтения массива из файла
        /// </summary>
        /// <returns>The array from file.</returns>
        public static int[] GetArrayFromFile()
        {
            string s;
            string filepath = "array.txt";
            s = File.ReadAllText(filepath);

            string[] arr = s.Split(' ');
            int[] array = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                array[i] = int.Parse(arr[i]);

            }
            return array;
        }


        /// <summary>
        /// Метод вывода массива
        /// </summary>
        /// <param name="array">Array.</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}  ");
            Console.WriteLine();
        }
    }
}
