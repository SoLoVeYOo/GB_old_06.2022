/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

//Примем что индекс НЕ равно позиция, а позиция начинается с 1, а не с 0 как индекс

using System;
using static System.Console;
using System.Linq;

int[] array = new int[Convert.ToInt32(Console.ReadLine())].Select(x => new Random().Next(0, 10)).ToArray();
WriteLine($"Massive -> {String.Join(" ", array)}");
int sum = 0;
for (int i = 0; i < array.Length; i += 2)
{
    sum += array[i];
}
Write($"Сумма элементов, стоящих на нечетных позициях = {sum}");