//Найти модуль числа

using System;
using static System.Console;

Write("Input number ");
int number = Convert.ToInt32(ReadLine());
if (number < 0)
{
    number = -number;
    Write($"Modul number is {number}");
}
else
{
    Write($"Modul number is {number}");
}