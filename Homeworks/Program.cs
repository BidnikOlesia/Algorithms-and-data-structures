using System;
using System.IO;
using System.Collections.Generic;

namespace Homeworks
{
    class MainClass
    {
        #region задание
        /*
         * 1. Оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и не оптимизированной программы. 
         * Написать функции сортировки, которые возвращают количество операций.
         * 2. *Реализовать шейкерную сортировку.
         * 3. Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный массив. 
         * Функция возвращает индекс найденного элемента или -1, если элемент не найден.
         * 4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма
         */

        #endregion


        public static void Main(string[] args)
        {

            Arrays.WriteArray(1000);

            Console.WriteLine("\nПузырьковая сортировка");
            int[] bArray1 = Arrays.GetArrayFromFile();
            int bSortSwaps;
            bArray1 = Arrays.BubbleSort(bArray1, out bSortSwaps);
            Console.WriteLine($"Количетво операций: {bSortSwaps}");

            Console.WriteLine("\nПузырьковая сортировка2");
            int[] bArray2 = Arrays.GetArrayFromFile();
            int bSort2Swaps;
            bArray2 = Arrays.BubbleSort2(bArray2, out bSort2Swaps);
            Console.WriteLine($"Количетво операций: {bSort2Swaps}");

            Console.WriteLine("\nШейкерная сортировка");
            int[] shArray = Arrays.GetArrayFromFile();
            int shSortSwaps;
            shArray = Arrays.ShakerSort(shArray, out shSortSwaps);
            Console.WriteLine($"Количетво операций: {shSortSwaps}");



            Console.WriteLine("\nПоиск индекса массива заданного значения");
            int value = 10;
            int index = Arrays.Search(value, shArray);
            if (index == -1)
                Console.WriteLine($"Элемент со значением {value} не найден");
            else Console.WriteLine($"Индекс = {index}");




        }
    }
}

