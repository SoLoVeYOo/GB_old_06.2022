/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

using System;
using static System.Console;

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(100);
}
WriteLine($"{String.Join(", ", array)} -> [{String.Join(", ", array)}]");