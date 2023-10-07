// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;

namespace task56
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] array = {
            {1, 4, 7, 2},
            {1, 1, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
        };

        MinSum(array);

        }

        static void MinSum(int[,] array){

        int minRowSum = int.MaxValue; 
        int minRowIndex = -1; 

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRowIndex = i;
            }
        }
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1} строка");

        }
        
    }
}
