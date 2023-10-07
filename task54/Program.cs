﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


using System;

namespace task54
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };
           SortRowsDescending(array);
           PrintArray(array);
        }

        static void PrintArray(int[,] array){
            for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        }

        static void SortRowsDescending(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int[] row = new int[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                row[j] = array[i, j];
            }

            Array.Sort(row, (a, b) => b.CompareTo(a));

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = row[j];
            }
        }
    }
    }
}
