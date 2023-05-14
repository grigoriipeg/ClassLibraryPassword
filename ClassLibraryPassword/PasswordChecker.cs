using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword
{
    public class PasswordChecker
    {
        private static Random rnd = new Random();
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 0 || password.Length > 20)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            FillArray(mas);
            Console.WriteLine("Исходный массив");
            OutputArray(mas);
            Console.WriteLine("\nСумма элементов");
            SumArray(mas);
            Console.WriteLine("\nСумма положительных элементов");
            SumPlusArray(mas);
            Console.ReadKey();
        }

        static void FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
            }
        }

        static void OutputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void SumArray(int[] array)
        {
            int sum = array.Sum();
            Console.WriteLine(sum);
        }

        static void SumPlusArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    sum += array[i];
            }
            Console.WriteLine(sum);
        }


    }
}
