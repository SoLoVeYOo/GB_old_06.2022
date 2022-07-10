/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) */

using System;
using static System.Console;

int[,,] GetArray(int rows, int colums, int depth)
{
    int[,,] result = new int[rows, colums, depth];
    int[,,] addNumber = new int[rows, colums, depth];
    int p = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                addNumber[i, j, k] = new Random().Next(10, 100);
                for (int l = 0; l < rows; l++)
                {
                    for (int m = 0; m < colums; m++)
                    {
                        for (int n = 0; n < depth; n++)
                        {
                            if (addNumber[i, j, k] != result[l, m, n]) p++;
                        }
                    }
                }
                if (p == rows * colums * depth)
                {
                    result[i, j, k] = addNumber[i, j, k];
                    p = 0;
                }
                else
                {
                    p = 0;
                    k = (k - 1);
                    continue;
                }
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
}

int[,,] res = GetArray(2, 2, 2);
PrintArray(res);