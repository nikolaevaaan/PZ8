// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

namespace task58
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = {
            {2, 4},
            {3, 2}
        };

        int[,] matrix2 = {
            {3, 4},
            {3, 3}
        };

        ResultArray(matrix1, matrix2);
        }

        static void ResultArray(int[,] matrix1, int[,] matrix2){

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != matrix2.GetLength(0))
        {
            Console.WriteLine("Нельзя умножить матрицы. Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            return;
        }

        int[,] resultMatrix = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

         Console.WriteLine("Результирующая матрица:");

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        }
        
    }
}
