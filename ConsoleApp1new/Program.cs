using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1new
{
    /// <summary>
    /// Разработайте программу, заполняющую массив из n элементов случайными целыми числами
    /// находящимся в интервале от 1 до 80. Выведите на экран пк созданный массив и найдите макс и мин, а так же осуществите их обмен.
    /// </summary>
    class Program
    {
        static void Output (string message)
        {
            Console.WriteLine(message);
        }
        static int[] Input(int size)
        {
            Random rndmin = new Random();
            int[] array = new int[size];
            for (int i = 0; i<size;i++)
            {
                array[i] = rndmin.Next(1,80);
            }
            return array;
        }
        //static void Swap (ref int x, ref int y)
        //{
        //    int p = x;
        //    x = y;
        //    y = p;
        //}
        static void OutPutmas(int[] omas)
        {
            foreach(var x in omas)
            {
                Console.WriteLine(x);
            }
        }
        static int GetSize()
        {
            Console.Write("Введите размер массива - ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка, введите новое значение.");
            }
            return size;
        }

        static void Main(string[] args)
        {
            int size = GetSize();
            int[] omas = Input(size);
            OutPutmas(omas);
            Console.WriteLine();
            int max = omas.Max();
            int min = omas.Min();
            int indmax = Array.IndexOf(omas, max);
            int indmin = Array.IndexOf(omas, min);
            int p = omas[indmax];
            omas[indmax]=omas[indmin];
            omas[indmin] = p;
            OutPutmas(omas);
            //Output("Полученные значения массива:");
            //OutPutmas(omas);
            //Output($"\nmaximum = {max}\nminimum = {min}");
            ////Swap(ref min, ref max);
            ////Swap(ref indmax, ref indmin);
            //Output($"\nalternative maximum = {max}\nalternative minimum = {min}");
            //Output("\nПолученные значения нового массива:");
            //OutPutmas(omas);
            Console.Read();
        }
    }
}
