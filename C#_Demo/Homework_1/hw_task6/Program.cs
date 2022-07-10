/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

using System;
using static System.Console;

Write("Input number ");
int number = Convert.ToInt32(ReadLine());
if (number%2 == 0) Write($"{number} is even number");
else Write($"{number} is odd number");