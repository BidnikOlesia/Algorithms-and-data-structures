using System;
using System.IO;
using System.Linq;
namespace Homeworks
{
    public class Sorts
    {

        #region Сортировка подсчетом
        public static int[] CountingSort(int[] array)
        {
            int[] count = new int[array.Max() + 1];
            for (int i = 0; i < array.Length; i++)
                count[array[i]]++;
            int index = 0;
            for (var i = 0; i < count.Length; i++)
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i;
                    index++;
                }
            return array;
        }
        #endregion


        #region Быстрая сортировка
        public static int[] Quicksort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }


        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return array;

            int pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }


        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        /// <summary>
        /// Метод, возвращающий индекс опорного элемента
        /// </summary>
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for(int i = minIndex;i<maxIndex; i++)
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        #endregion 


        #region Сортировка слиянием

        public static int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }

        static public int[] MergeSort(int[] array, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, (mid + 1), right);

                Merge(array, left, (mid + 1), right);
            }
            return array;
        }

        /// <summary>
        /// Метод слияния массивов
        /// </summary>
        static public void Merge(int[] array, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (array[left] <= array[mid])
                    temp[tmp_pos++] = array[left++];
                else
                    temp[tmp_pos++] = array[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = array[left++];

            while (mid <= right)
                temp[tmp_pos++] = array[mid++];

            for (i = 0; i < num_elements; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
        #endregion


        #region Сортировка со списком

        public static int[] PigeonholeSort(int[] array)
        {
            int length = array.Length;

            int min = array.Min();
            int max = array.Max();
            int range = max - min + 1;

            int[] pigeongoles = new int[range];
            for (int i = 0; i < length; i++)
                pigeongoles[array[i] - min]++;

            int index = 0;
            for (int j = 0; j < range; j++)
            {
                while(pigeongoles[j]-- >0)
                {
                    array[index] = j + min;
                    index++;
                }


            }
            return array;
        }
        #endregion


        #region Создание, чтение и вывод массива
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
                array[i] = int.Parse(arr[i]);
            return array;
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

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}  ");
            Console.WriteLine();
        }

        #endregion
    }
}
