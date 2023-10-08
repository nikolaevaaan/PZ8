// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;

namespace task62
{
    class Program
    {
        static void Main(string[] args)
        {
         int n = 4;
         int[,] spiralArray = new int[n, n];
         SpiralArray(n, spiralArray);
        }

        static void SpiralArray(int n, int[,] spiralArray){

        int value = 1;
        int startRow = 0, endRow = n - 1, startCol = 0, endCol = n - 1;

        while (startRow <= endRow && startCol <= endCol)
        {
            for (int i = startCol; i <= endCol; i++)
            {
                spiralArray[startRow, i] = value++;
            }
            startRow++;

            for (int i = startRow; i <= endRow; i++)
            {
                spiralArray[i, endCol] = value++;
            }
            endCol--;

            if (startRow <= endRow)
            {
                for (int i = endCol; i >= startCol; i--)
                {
                    spiralArray[endRow, i] = value++;
                }
                endRow--;
            }

            if (startCol <= endCol)
            {
                for (int i = endRow; i >= startRow; i--)
                {
                    spiralArray[i, startCol] = value++;
                }
                startCol++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{spiralArray[i, j]:D2} ");
            }
            Console.WriteLine();
        }
        }
    }
}
