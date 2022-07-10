/* Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент. */

using System;
using static System.Console;

Write("Колличество строк ");
int r = Convert.ToInt32(ReadLine());
Write("Колличество столбцов ");
int c = Convert.ToInt32(ReadLine());

int[,] GetArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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

int[] FindRowColum(int[,] array)
{
    int[] newArray = new int[]{0,0};
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                newArray[0] = i;
                newArray[1] = j;
                min = array[i, j];
            }    
        }
    }
    return newArray;
}

int[,] NewArray(int[,] array, int[] array2)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0, l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == array2[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array2[1]) continue;
            newArray[k, l] = array[i, j];
            l++;
        }
        l = 0;
        k++;
    }
    return newArray;
}

int[,] res = GetArray(r, c);
PrintArray(res);
WriteLine();
int[] res2 = FindRowColum(res);
PrintArray(NewArray(res, res2));