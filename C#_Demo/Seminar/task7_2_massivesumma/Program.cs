/* Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран. */

using System;
using static System.Console;

WriteLine("Input number n");
int n = Convert.ToInt32(ReadLine());
WriteLine("Input number m");
int m = Convert.ToInt32(ReadLine());

int[,] GetArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = i + j;
            Write($"{result[i,j]} ");
        }
        WriteLine();
    }
    return result;
}
int[,] res = GetArray(n, m);