using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 5-1. Одномерный массив и ср. арифметическое
            Console.WriteLine("Введите количество элементов массива:\t");
            int elCount = int.Parse(Console.ReadLine());
            int[] array = new int[elCount];
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i]; 
            }
            //foreach (int a in array) - почему-то отрабатывает без первого элемента и выдает ошибку
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Среднее арифметическое элементов массива равно {0}", sum / array.Length);
            Console.ReadKey();
        }
    }
}
