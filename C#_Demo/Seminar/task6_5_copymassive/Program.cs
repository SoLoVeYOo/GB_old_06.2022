// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

using System;
using System.Linq;
using static System.Console;
Clear();

int length = Convert.ToInt32(ReadLine());
int[] ar = new int[length].Select(x => x = new Random().Next(0, 10)).ToArray();
WriteLine(String.Join(" ", ar));

int[] CopyArray(int[] arr)
{
    int[] pastarray = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        pastarray[i] = arr[i];
    }
    return pastarray;
}
WriteLine(String.Join(" ", CopyArray(ar)));