/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

using System;
using static System.Console;

Write("Колличество строк и столбцов ");
int r = Convert.ToInt32(ReadLine());

int[,] GetArray(int rowsColums)
{
    int[,] result = new int[rowsColums, rowsColums];
    int number = 1;
    for (int i = 0; i < rowsColums / 2 + 1; i++)
    {
        for (int j = i; j < rowsColums - i; j++)
        {
            result[i, j] = number++;
        }
        for (int k = i + 1; k < rowsColums - i; k++)
        {
            result[k, rowsColums - 1 - i] = number++;
        }
        for (int j = rowsColums - i - 2; j >= i; j--)
        {
            result[rowsColums - 1 - i, j] = number++;
        }
        for (int k = rowsColums - 2 - i; k > i; k--)
        {
            result[k, i] = number++;
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

int[,] res = GetArray(r);
PrintArray(res);