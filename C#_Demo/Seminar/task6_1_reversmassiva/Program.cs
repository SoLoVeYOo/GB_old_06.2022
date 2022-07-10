/* Задача 39:** Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.) 

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

using System;
using System.Linq;
using static System.Console;
Clear();

// универсальное решение
/* int[] ar = new int[5].Select(x => x = new Random().Next(0, 10)).ToArray();
WriteLine(String.Join(" ", ar));
WriteLine(String.Join(" ", ar.Reverse())); */

int length = 10;
int[] ar = new int[length].Select(x => x = new Random().Next(0, 10)).ToArray();
WriteLine(String.Join(" ", ar));

// 1-й способ
/* for (int i = 0; i < length / 2; i++)
{
    int k = ar[i];
    ar[i] = ar[length - i - 1];
    ar[length - i - 1] = k;
}
WriteLine(String.Join(" ", ar)); */

// 1-й способ c методом
/* void Revers(int a1, int a2)
{
    int r = a1;
    a1 = a2;
    a2 = r;
}
for (int i = 0; i < length / 2; i++)
{
    Revers(ar[i], ar[length - i - 1]);
}
WriteLine(String.Join(" ", ar)); */

// 2-й способ (лучше использовать когда предыдущие данные тоже нужны)
int[] ar1 = new int[length];
for (int i = 0; i < length; i++)
{
     ar1[length - i - 1] = ar[i];
}
WriteLine(String.Join(" ", ar1));