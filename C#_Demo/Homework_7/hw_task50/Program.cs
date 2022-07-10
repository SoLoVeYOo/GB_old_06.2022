/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

using System;
using static System.Console;

Write("Колличество строк ");
int r = Convert.ToInt32(ReadLine());
Write("Колличество столбцов ");
int c = Convert.ToInt32(ReadLine());
Write("Искомая позиция ");
string find = Convert.ToString(ReadLine());
int a = Convert.ToInt32(find[0].ToString());
int b = Convert.ToInt32(find[1].ToString());

int[,] GetArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(0, 99);
            Write($"{result[i, j]} ");
        }
        WriteLine();
    }
    return result;
}

bool FindElements(int[,] array2, int num1, int num2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (i == num1 && j == num2) return true;
        }
    }
    return false;
}
WriteLine();
int[,] res = GetArray(r, c);
WriteLine();
WriteLine(FindElements(res, a, b) ? $"Значение искомого числа = {res[a, b]}" : "Число отсутсвует в массиве");