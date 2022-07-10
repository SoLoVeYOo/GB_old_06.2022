/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

using System;
using static System.Console;

Write("Input number N = ");
int N = Convert.ToInt32(ReadLine());
int count = 2;
if (N <= 0) Write("Error");
if (N == 1) Write("No is even numbers");
else
{
    while (count <= N)
    {
        Write($"{count} ");
        count+=2;
    }
}