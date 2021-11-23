using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 5-6. Двумерный массив. Магический квадрат
            Console.WriteLine("Введите количество элементов массива N:\t");
            int elCount = int.Parse(Console.ReadLine());
            int[,] array = new int[elCount, elCount];
            for (int i = 0; i < elCount; i++)
            {
                for (int j = 0; j < elCount; j++)
                {
                    Console.Write($"\nВведите элемент массива под индексом {i}, {j}:\t ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sumStr = 0;
            int sumStb = 0;
            int sumDig1 = 0;
            int sumDig2 = 0;
            for (int i = 0; i < elCount; i++)
            {
                for (int j = 0; j < elCount; j++)
                {
                    sumDig1 += array[i, i];
                    sumDig2 += array[j, j];
                    sumStr += array[i, j];
                }
            }
            for (int j = 0; j < elCount; j++)
            {
                for (int i = 0; i < elCount; i++)
                {
                    sumStb += array[i, j];
                }
            }
            bool f = true;
            for (int i = 0; i < elCount; i++)
            {
                int str = 0;
                for (int j = 0; j < elCount; j++)
                {
                   str += array[i, j];
                }
                if (str != sumStr / elCount)
                {
                    f = false;
                    break;
                }    
            }
            for (int j = 0; j < elCount; j++)
            {
                int stb = 0;
                for (int i = 0; i < elCount; i++)
                {
                    stb += array[i, j];
                }
                if (stb != sumStb / elCount)
                {
                    f = false;
                    break;
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
            if (sumStr / elCount == sumStb / elCount && sumDig1 == sumDig2 && sumDig1 == sumStr && f == true)
            {
                Console.WriteLine("\nВведенная матрица - является магическим квадратом");
            }
            else
            {
                Console.WriteLine("\nВведенная матрица - не является магическим квадратом");
            }
            /*int l = array.GetLength(0);
            int p = array[0, l - 1];
            int o = array.GetLength(1) + l - 2;
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                schet += (array[i, l - 1] == p) ? 1 : 0;
                schet += (array[l - 1, i] == p) ? 1 : 0;
            }
            
            if (schet == o)
            {
                Console.WriteLine("\nВведенная матрица - является магическим квадратом");
            }
            else
            {
                Console.WriteLine("\nВведенная матрица - не является магическим квадратом");
            }*/
            Console.ReadKey();
        }
    }
}
            