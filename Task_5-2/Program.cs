using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 5-2. Одномерный массив. Max и min
            Console.WriteLine("Введите количество элементов массива:\t");
            int elCount = int.Parse(Console.ReadLine());
            int[] array = new int[elCount];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 50);
            }
            Console.WriteLine("\nЭлементы массива:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            foreach (int a in array)
            {   
                if (a < min)
                    min = a;
            }
            Console.WriteLine($"\nСумма максимального {max} и минимального {min} элементов массива равна {max + min}");
            Console.ReadKey();
        }
    }
}
