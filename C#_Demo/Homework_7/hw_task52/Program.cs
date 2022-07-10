/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using System;
using static System.Console;

Write("Колличество строк ");
int r = Convert.ToInt32(ReadLine());
Write("Колличество столбцов ");
int c = Convert.ToInt32(ReadLine());
WriteLine();

int[,] GetArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(0, 10);
            Write($"{result[i, j]} ");
        }
        WriteLine();
    }
    return result;
}

void FindSrednearif(int[,] array, int row)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Write("{0:0.00} ", sum / row );
    }
}
int[,] res = GetArray(r, c);
WriteLine();
WriteLine($"Среднее арифметическое каждого столбца: ");
FindSrednearif(res, r);