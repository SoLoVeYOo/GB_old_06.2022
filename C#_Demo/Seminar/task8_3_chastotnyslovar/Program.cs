/* **Задача 57:** Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

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

int[] MultArray(int[,] array) //преобразовывает массив в строку
{
    int k = 0;
    int[] newArray = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[k] = array[i, j];
            k++;
        }
    }
    return newArray;
}

void SortArray(int[] array) //стандартная пузырьковая сортировка
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int k = array[i];
                array[i] = array[j];
                array[j] = k;
            }
        }
    }
}

void PrintMultArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

void PrintData(int[] array) //счетчик
{
    int el = array[0];
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != el)
        {
            WriteLine($"{el} встречается {count} раз");
            el = array[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el} встречается {count} раз");
}

int[,] res = GetArray(r, c);
PrintArray(res);
WriteLine();
int[] resAr = MultArray(res);
PrintMultArray(resAr);
WriteLine();
SortArray(resAr);
PrintMultArray(resAr);
PrintData(resAr);
