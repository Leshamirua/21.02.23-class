using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._23_class
{
    internal class Program
    {
        /* Создайте анонимный метод для проверки числа на 
чётность. Напишите код для тестирования работы метода.
        Создайте анонимный метод для подсчёта квадрата 
числа. Напишите код для тестирования работы метода.

         Создайте лямбда-выражение для подсчёта куба числа. 
Напишите код для тестирования работы лямбды.

         Создайте лямбда-выражение для проверки является 
ли заданный день днём программиста (день программиста – 256 день года). Напишите код для тестирования 
работы лямбды   

        Создайте лямбда-выражение для поиска максимума в 
массиве. Напишите код для тестирования работы лямбды

        Создайте лямбда-выражение для поиска минимума в 
массиве. Напишите код для тестирования работы лямбды.

        Создайте лямбда-выражение для поиска нечётных 
чисел в массиве. Напишите код для тестирования работы 
лямбды
         */

        static void Main(string[] args)
        {
            Del1 del1 = delegate (int a)
            {
                return a % 2 == 0;
            };
            Console.WriteLine(del1(12));
            Del2 del2 = delegate (int a)
            {
                return a * a;
            };
            Del3 del3 = i => i * i * i;
            Del4 del4 = i => i == 256;
            Del5 del5 = (int[] arr) =>
            {
                int max = arr[0];
                foreach (int a in arr)
                {
                    
                    if (a > max)
                    {
                        max = a;
                    }
                }
                return max;
            };
            Del6 del6 = (int[] arr) =>
            {
                int min = arr[0];
                foreach (int a in arr)
                {
                    if (a < min)
                        min = a;
                }
                return min;
            };
            Del7 del7 = (int[] arr) =>
            {
                int el = 0;
                foreach (int a in arr)
                {
                    if (a % 2 != 0)
                        el++;
                }
                return el;
            };
        }
    }
    delegate bool Del1(int x);
    delegate int Del2(int x);
    delegate int Del3(int x);
    delegate bool Del4(int x);
    delegate int Del5(int[] x);
    delegate int Del6(int[] x);
    delegate int Del7(int[] x);
}
