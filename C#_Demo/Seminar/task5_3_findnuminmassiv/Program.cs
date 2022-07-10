/* Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

using System;
using static System.Console;

Write("Input number ");
int find = Convert.ToInt32(ReadLine());

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] array = GetArray(10, 0, 10);
WriteLine($"Massive -> {String.Join(" ", array)}");

bool Find(int[] arr, int num)
{
    foreach (int item in arr)
    {
        if (item == num) return true;
    }
    return false;
}
WriteLine(Find(array, find) ? "Число присутсвует в массиве" : "Число отсутсвует в массиве");

/* using System;
using System.Linq;

int[] array=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
int[] array1=array.Select(x=>x*-1).ToArray();
int size=int.Parse(Console.ReadLine());
int[] array2=new int[int.Parse(Console.ReadLine())].Select(x=>new Random().Next(0,100)).ToArray();
Console.WriteLine(String.Join(" ",array));
Console.WriteLine(String.Join(" ",array1));
Console.WriteLine(String.Join(" ",array2)); */