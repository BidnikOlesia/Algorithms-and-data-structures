using System;
using System.Text;
using System.Security.Cryptography;

#region
/*
 * 1. Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе сумма кодов символов.
 * 2. Переписать программу, реализующее двоичное дерево поиска.
     а) Добавить в него обход дерева различными способами;
     б) Реализовать поиск в двоичном дереве поиска;
     в) *Добавить в программу обработку командной строки с помощью которой можно указывать из какого файла считывать данные, каким образом обходить дерево.
 * 3. *Разработать базу данных студентов из двух полей “Имя”, “Возраст”, “Табельный номер” в которой использовать все знания, полученные на уроках.
     Считайте данные в двоичное дерево поиска. Реализуйте поиск по какому-нибудь полю базы данных (возраст, вес)
 */
#endregion

namespace Homeworks
{
    class MainClass
    {
        public static string GetHash(string source)
        {
            using (var md5Hash = MD5.Create())
            {
                var sourceBytes = Encoding.UTF8.GetBytes(source);
                var hashBytes = md5Hash.ComputeHash(sourceBytes);
                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                return hash;
            }
        }


        public static void Main(string[] args)
        {
            #region task1
            Console.WriteLine("Введите строку");
            string source = Console.ReadLine();
            Console.WriteLine($"{GetHash(source)}");
            #endregion

            #region task2
            BinaryTree<int> tree = new BinaryTree<int>();

            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                int value = rand.Next(100);
                Console.WriteLine("Adding {0}", value);
                tree.Add(value);
            }

            Console.WriteLine("Preorder traversal:");
            Console.WriteLine(string.Join(" ", tree.Preorder()));
            Console.WriteLine("Inorder traversal:");
            Console.WriteLine(string.Join(" ", tree.Inorder()));
            Console.WriteLine("Postorder traversal:");
            Console.WriteLine(string.Join(" ", tree.Postorder()));
            #endregion

        }
    }
}
