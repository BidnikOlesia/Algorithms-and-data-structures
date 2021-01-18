using System;
namespace Homeworks
{
    public static class task1
    {

        /*
         * 1. *Количество маршрутов с препятствиями. Реализовать чтение массива с препятствием и нахождение количество маршрутов.
                Например, карта: 33
                111
                010
                010 
         */

        public static void Print(int n, int m, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Barrier()
        {
            int n = 3;
            int m = 3;
            int[,] a = new int[n, m];

            int[,] map = {
                { 1, 1, 1 } ,
                { 1, 1, 1 } ,
                { 0, 1, 1 }};

            for (int j = 0; j < m; j++)
            {
                if (map[0, j] == 1)
                    a[0, j] = 1;
                else
                    a[0, j] = 0;
            }

            for (int i = 1; i < n; i++)
            {
                if (map[i, 0] == 1)
                    a[i, 0] = 1;
                else
                    a[i, 0] = 0;

                for (int j = 1; j < m; j++)
                {
                    if (map[i, j] == 1)
                        a[i, j] = a[i, j - 1] + a[i - 1, j];
                    else
                        a[i, j] = 0;
                }

            }

            Print(n, m, a);
        }
    }
}
