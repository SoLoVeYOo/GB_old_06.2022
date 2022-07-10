/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

using System;
using static System.Console;
using System.Linq;

int[] array = new int[Convert.ToInt32(Console.ReadLine())].Select(x => new Random().Next(100, 1000)).ToArray();
WriteLine($"Massive -> {String.Join(" ", array)}");
int col = 0;
//for (int i = 0; i < array.Length; i++)
foreach (int num in array)
{
    if (num % 2 == 0) col++;
}
Write($"Количество четных чисел в массиве = {col}");