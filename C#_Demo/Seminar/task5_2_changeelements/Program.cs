/* Задача 32:** Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот. 
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

using System;

int[] array = { -3, 7, 5, -4 };
Console.WriteLine(String.Join(" ", array));

int[] Replace(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    arr[i] = -arr[i];
    }
    return arr;
}
Replace(array);
Console.WriteLine(String.Join(" ", array));