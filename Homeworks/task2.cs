using System;
namespace Homeworks
{
    public class task2
    {
        /*
         * 2. Решить задачу о нахождении длины максимальной последовательности с помощью матрицы
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

        static int max(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int lcs_length(string A, string B, int i = 0, int j = 0)
        {
            if (A.Length <= i || B.Length <= j) return 0;

            else if (A[i] == B[j]) return 1 + lcs_length(A, B, i + 1, j + 1);
            else return max(lcs_length(A, B, i + 1, j), lcs_length(A, B, i, j + 1));
        }



        public static void getLcs(char[] a, char[] b)
        {
            int m = a.Length;
            int n = b.Length;
            int[,] len = new int[m + 1, n + 1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i] == b[j])
                    {
                        len[i + 1, j + 1] = len[i, j] + 1;
                    }
                    else
                    {
                        len[i + 1, j + 1] = max(len[i + 1, j], len[i, j + 1]);
                    }
                }
            }


            int cnt = len[m, n];
            char[] res = new char[cnt];
            for (int i = m - 1, j = n - 1; i >= 0 && j >= 0;)
            {
                if (a[i] == b[j])
                {
                    res[--cnt] = a[i];
                    i--;
                    j--;
                }
                else if (len[i + 1, j] > len[i, j + 1])
                    j--;
                else
                    i--;
            }
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($" {res[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"длина подпоследовательности: {len[m, n]}");
            Print(m, n, len);
        }
    }
}
