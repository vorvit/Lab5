using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 5-3. Одномерный массив. Сортировка
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
            }
            Console.WriteLine("\nЭлементы массива до сортировки:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int i = 5; i < array.Length; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine("\nЭлементы массива после сортировки:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
            Console.ReadKey();
        }
    }
}
