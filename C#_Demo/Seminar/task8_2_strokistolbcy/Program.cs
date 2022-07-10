/* Задача 55:** Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7 */

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

void TurnArray(int[,] array) //метод по замене только квадратных массивов
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int temp;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(1); j++) // for (int j = 0; j < i; j++) два метода - делается для того чтобы за цикл не было двайной замены
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    else WriteLine("Замена невозможна");
}

int[,] TurnArray2(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    return newArray;
}

int[,] res = GetArray(r, c);
PrintArray(res);
WriteLine();
PrintArray(TurnArray2(res));