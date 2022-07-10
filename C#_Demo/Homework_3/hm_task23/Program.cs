/* Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

using System;
using static System.Console;

WriteLine("Input number ");
int N = Convert.ToInt32(ReadLine());
int index = 1;
Write($"{N} ->");
while (index <= N)
{
    Write($" {Math.Pow(index, 3)}");
    index++;
}