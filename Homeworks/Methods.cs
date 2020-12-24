using System;
namespace Homeworks
{
    public static class Methods
    {
        /// <summary>
        /// Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.
        /// </summary>
        /// <returns>The bin.</returns>
        /// <param name="dec">Dec.</param>
        public static string ToBin(int dec)
        {
            if (dec == 0)
                return "";
            else
                return ToBin(dec / 2) + (dec % 2).ToString();
        }


        /// <summary>
        /// Реализовать функцию возведения числа a в степень b: Без рекурсии.
        /// </summary>
        /// <returns>The pow.</returns>
        /// <param name="a">The alpha component.</param>
        /// <param name="b">The blue component.</param>
        public static int Pow(int a, int b)
        {
            int pow = 1;
            for (int i = 1; i <= b; i++)
            {
                pow *=  a;
            }
            return pow;
        }

        /// <summary>
        /// Реализовать функцию возведения числа a в степень b: Рекурсивно.
        /// </summary>
        /// <returns>The rec.</returns>
        /// <param name="a">The alpha component.</param>
        /// <param name="b">The blue component.</param>
        public static int powRec(int a, int b)
        {

            if (b == 0)
                return 1;
            else
                return powRec(a, b - 1) * a;

        }

        /// <summary>
        /// Реализовать функцию возведения числа a в степень b: Рекурсивно, используя свойство чётности степени.
        /// </summary>
        /// <returns>The pow.</returns>
        /// <param name="a">The alpha component.</param>
        /// <param name="b">The blue component.</param>
        public static int powRec2(int a, int b)
        {
            int c;
            if (b == 0)
                return 1;
            else if (b % 2 == 1)
                return powRec2(a, b - 1) * a;
            else
            {
                c = powRec2(a, b / 2);
                return c * c;
            }
        }


        /// <summary>
        /// Метод, подсчитывающий количество программ, которые преобразуют число а в b
        /// </summary>
        public static void GetNumArray(int init, int final)
        {
            int[] f = new int[100];
            f[init] = 1;
            for (int i = init + 1; i <= final; i++)
                f[i] = i % 2 == 0 ? f[i - 1] + f[i / 2] : f[i - 1];
            Console.WriteLine(f[final]);
        }


    }
}
