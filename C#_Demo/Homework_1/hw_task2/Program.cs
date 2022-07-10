/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

using System;
using static System.Console;

Write("Input number a = ");
int a = Convert.ToInt32(ReadLine());
Write("Input number b = ");
int b = Convert.ToInt32(ReadLine());
int max = a;
int min = a;
if (b > max) max = b;
else min = b;
Write($"Max number = {max}, min number = {min}");