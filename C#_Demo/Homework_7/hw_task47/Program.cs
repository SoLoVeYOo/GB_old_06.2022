/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

using System;
using static System.Console;

Write("Колличество строк ");
int r = Convert.ToInt32(ReadLine());
Write("Колличество столбцов ");
int c = Convert.ToInt32(ReadLine());

double[,] GetArray(int rows, int colums)
{
    double[,] result = new double[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().NextDouble() * 20 - 10;
            Write("{0:0.00} ", result[i, j]);
        }
        WriteLine();
    }
    return result;
}
double[,] res = GetArray(r, c);