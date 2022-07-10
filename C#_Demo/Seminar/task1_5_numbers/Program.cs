//Показать вcе целые числа от -N до N

using System;
using static System.Console;

Write("Input number N ");
int N = Convert.ToInt32(ReadLine());
int number = -N;
while (number <= N)
{
    Write($"{number} ");
    number++;
}