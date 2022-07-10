/* Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

using System;
using static System.Console;
using System.Linq;

int[] array = new int[int.Parse(Console.ReadLine())].Select(x => new Random().Next(1, 10)).ToArray();
WriteLine($"Massive -> {String.Join(" ", array)}");
Write($"Произведение парных чисел -> ");
void NewMassive(int[] arr) //для вывода именно как массив, можно было и без метода
{
    int temp = array.Length - 1; // proiz = 0;
    for (int i = 0; i <= temp; i++)
    {
        Write(i < temp ? $"{array[i] * array[temp]} " : $"{array[i]} ");
        temp--;
    }
}
NewMassive(array);

/* Данный алгоритм не показывает число по середине если количество элементов в массиве нечетное
for (int i = 0; i <= temp; i++)
{
    if ()
    int proiz = array[i] * array[temp];
    Write($"{proiz} ");
    temp--;
} */