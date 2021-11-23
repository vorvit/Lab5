using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 5-5. Двумерный массив. 1 и 0
            Console.WriteLine("Введите количество элементов массива N:\t");
            int elCount = int.Parse(Console.ReadLine());
            int[,] array = new int[elCount, elCount];
            for (int i = 0; i < elCount; i++)
            {
                for (int j = 0; j < elCount; j++)
                {
                    array[i, j] = 1 - (i + j) % 2;
                }
            }
            Console.WriteLine("\nЭлементы массива:\n");
            for (int i = 0; i < elCount; i++)
            {
                for (int j = 0; j < elCount; j++)
                {
                    Console.Write("{0, 4} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
