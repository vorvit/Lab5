using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 5-4. Одномерный массив. Количество нечетных положительных элементов на четных местах
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
            }
            Console.WriteLine("\nЭлементы массива:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($" {i+1} = {array[i]}");
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] % 2 != 0 && (i+1) % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"\nКоличество нечетных положительных элементов, стоящих на четных местах равно {count}\n");
            Console.ReadKey();
        }
    }
}
