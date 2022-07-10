//Проверка является ли второе число квадратом первого

using System;
using static System.Console;

Write("Input number ");
double number = double.Parse(ReadLine()); //можно double number = Convert.ToDouble(ReadLine());
Write("Input squre number ");
double sqr = double.Parse(ReadLine());
if (number * number == sqr)
{
    WriteLine($"Number {sqr} is squre number {number}");
}
else
{
    WriteLine($"Number {sqr} do't is squre number {number}");
}