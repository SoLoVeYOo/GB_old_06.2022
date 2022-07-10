/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


using System;
using static System.Console;
using System.Linq;

double[] array = new double[Convert.ToInt32(Console.ReadLine())].Select(x => new Random().NextDouble()*100).ToArray();
WriteLine($"Massive -> {String.Join(" ", array)}");
double max = array[0], min = array[0];
for (int i = 0; i < array.Length; i ++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
WriteLine($"Разница между максимальным и минимальным числом равна = {max - min}");