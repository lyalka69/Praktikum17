using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Выполнить инициализацию одномерного массива с использованием конструктора без указания значений элементов, заполнить массив с клавиатуры и вывести на экран.
            //int i;
            //int[] omas = new int[6];
            //for (i = 0; i < omas.Length; i++)
            //{
            // Console.Write($"omas[{i}]= ");
            // omas[i] = int.Parse(Console.ReadLine());

            //}
            //for (i = 0; i < omas.Length; i++)
            //{
            // Console.Write($"omas[{i}]={omas[i]} ");
            //}
            //Console.ReadKey();

            //2) Инициализировать одномерный массив с использованием конструктора , без указания размерности массива и без клавиатуры.

            int[] omas = { -3, 5, 7, -1, 10, 15 };
            int i;

            for (i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]} ");
            }
            Console.ReadKey();

            //3) Заполнить одномерный массив соответствующими индексами (по формуле) и вывести с использованием цикла foreach.

        }
    }
}
