/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

using System;
using static System.Console;

Write("Input number a = ");
int a = Convert.ToInt32(ReadLine());
Write("Input number b = ");
int b = Convert.ToInt32(ReadLine());
Write("Input number c = ");
int c = Convert.ToInt32(ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Write($"Max number = {max}");