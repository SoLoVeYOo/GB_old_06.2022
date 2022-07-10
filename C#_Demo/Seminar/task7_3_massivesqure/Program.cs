/* Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты. */

using System;
using static System.Console;

WriteLine("Input number n");
int r = Convert.ToInt32(ReadLine());
WriteLine("Input number m");
int c = Convert.ToInt32(ReadLine());
WriteLine("Input number n");
int mi = Convert.ToInt32(ReadLine());
WriteLine("Input number m");
int ma = Convert.ToInt32(ReadLine());

int[,] GetArray(int rows, int colums, int min, int max)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(min, max);
            Write($"{result[i, j]} ");
        }
        WriteLine();
    }
    return result;
}

int[,] ArraySqure(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (i > 1 && j > 1 && i % 2 == 0 && j % 2 == 0) array2[i, j] = array2[i, j] * array2[i, j];
            Write($"{array2[i, j]} ");
        }
        WriteLine();
    }
    return array2;
}


int[,] res = GetArray(r, c, mi, ma);
WriteLine();
int[,] res2 = ArraySqure(res);