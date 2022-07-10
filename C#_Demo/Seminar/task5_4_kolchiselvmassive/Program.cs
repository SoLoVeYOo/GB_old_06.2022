/* Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

using System;
using static System.Console;
using System.Linq;

int[] array = new int[123].Select(x => new Random().Next(0, 200)).ToArray();
WriteLine($"Massive -> {String.Join(" ", array)}");

/* Другой вариант через библиотеку Linq
int k = array.Where(x => x >= 10 && x <= 99).Count(); - или
int k = new int[123].Select(x => new Random().Next(0, 200)).Where(x => x >= 10 && x <= 99).Count(); - все одной строчкой, но мы не увидим сам массив
WriteLine($"Количество чисел в массиве в отрезке от 10 до 99 = {k}"); 

int[] k = new int[123].Select(x => new Random().Next(0, 200)).Where(x => x >= 10 && x <= 99).ToArra(); - покажи мне эти самые цифры в виде массива
WriteLine($"Massive -> {String.Join(" ", k)}");
*/

int col = 0;
foreach (int item in array)
{
    if (item > 10 && item < 99) col++;
}
WriteLine($"Количество чисел в массиве в отрезке от 10 до 99 = {col}");