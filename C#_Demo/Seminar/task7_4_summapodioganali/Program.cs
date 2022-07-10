/* Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. */

using System;
using static System.Console;

WriteLine("Input number n");
int r = Convert.ToInt32(ReadLine());
WriteLine("Input number n");
int mi = Convert.ToInt32(ReadLine());
WriteLine("Input number m");
int ma = Convert.ToInt32(ReadLine());

int[,] GetArray(int rows, int min, int max)
{
    int sum = 0;
    int[,] result = new int[rows, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            result[i, j] = new Random().Next(min, max);
            Write($"{result[i, j]} ");
            if (i == j) sum += result[i, j];
        }
        WriteLine();
    }
    WriteLine($"Сумма = {sum}");
    return result;
}
int [,] res = GetArray(r, mi, ma);

// int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);