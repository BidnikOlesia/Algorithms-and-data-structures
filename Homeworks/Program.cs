using System;

#region задание
/*
 * 1. Реализовать сортировку подсчетом.
 * 2. Реализовать быструю сортировку.
 * 3. *Реализовать сортировку слиянием.
 * 4. **Реализовать алгоритм сортировки со списком
 */
#endregion
namespace Homeworks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sorts.WriteArray(10);

            Console.WriteLine("Сортировка подсчетом");
            int[] array1 = Sorts.GetArrayFromFile();
            Console.Write("Массив: ");
            Sorts.PrintArray(array1);
            array1 = Sorts.CountingSort(array1);
            Console.Write("Отсортированный массив: ");
            Sorts.PrintArray(array1);


            Console.WriteLine("Быстрая сортировка");
            int[]array2 = Sorts.GetArrayFromFile();
            Console.Write("Массив: ");
            Sorts.PrintArray(array2);
            array1 = Sorts.Quicksort(array2);
            Console.Write("Отсортированный массив: ");
            Sorts.PrintArray(array2);

            Console.WriteLine("Сортировка слиянием");
            int[] array3 = Sorts.GetArrayFromFile();
            Console.Write("Массив: ");
            Sorts.PrintArray(array3);
            array1 = Sorts.MergeSort(array3);
            Console.Write("Отсортированный массив: ");
            Sorts.PrintArray(array3);

            Console.WriteLine("Сортировка со списком");
            int[] array4 = Sorts.GetArrayFromFile();
            Console.Write("Массив: ");
            Sorts.PrintArray(array4);
            array1 = Sorts.PigeonholeSort(array4);
            Console.Write("Отсортированный массив: ");
            Sorts.PrintArray(array4);
        }
    }
}

