/* Задача 31:** Задайте массив из 12 элементов, заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива. */

using System;

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int sumP = 0;
int sumO = 0;
/* for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) sumP = sumP + array[i];
    else sumO = sumO + array[i];
} */
foreach (int item in array) 
//обращение к каждому элементу массива по порядку, цикл будет идти пока не обратится ко всем элементам
//переменная item только для четения, в неё нельзя записать что либо, её нельзя удалить и её нельзя изменить
{
    sumP += item > 0 ? item : 0;
    sumO += item < 0 ? item : 0;
}
Console.WriteLine($"Summa polozitelnyh chisel = {sumP}, summa otricatelnyh = {sumO}");