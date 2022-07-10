//Найти последнию цифру числа

using System;
using static System.Console;

Write("Input number ");
int number = Convert.ToInt32(ReadLine());
int lastN = number%10;
Write($"Last number is {lastN}");