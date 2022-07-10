//Найти обратное число (1 / N)

using System;
using static System.Console;

Write("Input number ");
double number = Convert.ToDouble(ReadLine());
double Rnumber = 1 / number;
Write($"Return number is {Rnumber}");