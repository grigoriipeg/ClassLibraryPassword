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
            var number = false;
            var symbols = false;
            var upper = false;
            var lower = false;

            if (password.Length >= 8 && password.Length <= 20)
            {
                foreach (char c in password)
                {
                    if (Char.IsNumber(c))
                    {
                        number = true;
                    }
                    if (Char.IsLower(c))
                    {
                        lower = true;
                    }
                    if (Char.IsUpper(c))
                    {
                        upper = true;
                    }
                    if (Char.IsPunctuation(c) || Char.IsSeparator(c) || Char.IsSymbol(c))
                    {
                        symbols = true;
                    }
                }
            }

            if (number && symbols && lower && upper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PasswordLength(string password)
        {
            if (password.Length >= 8 && password.Length <= 20)
            {       
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PasswordNumber(string password)
        {
            var number = false;
            if (password.Length >= 8 && password.Length <= 20)
            {   
                foreach (char c in password)
                {
                    if (Char.IsNumber(c))
                    {
                       number = true;
                    }
                }              
            }
            return number;
        }

        public static bool PasswordSymbols(string password)
        {
            var symbol = false;
            if (password.Length >= 8 && password.Length <= 20)
            {
                foreach (char c in password)
                {
                    if (Char.IsPunctuation(c) || Char.IsSeparator(c) || Char.IsSymbol(c))
                    {
                        symbol = true;
                    }
                }
            }
            return symbol;
        }

        public static bool PasswordLower(string password)
        {
            var lower = false;
            if (password.Length >= 8 && password.Length <= 20)
            {
                foreach (char c in password)
                {
                    if (Char.IsLower(c))
                    {
                        lower = true;
                    }
                }
            }
            return lower;
        }

        public static bool PasswordUpper(string password)
        {
            var upper = false;
            if (password.Length >= 8 && password.Length <= 20)
            {
                foreach (char c in password)
                {
                    if (Char.IsUpper(c))
                    {
                        upper = true;
                    }
                }
            }
            return upper;
        }




        /*static void Main(string[] args)
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
    }*/
    }
}
