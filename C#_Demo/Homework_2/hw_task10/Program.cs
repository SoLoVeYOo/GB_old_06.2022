/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

using System;
using static System.Console;
Console.Clear();

WriteLine("Input number ");
int num = Convert.ToInt32(ReadLine());
string numS = num.ToString();
WriteLine($"{num} -> second number is {Convert.ToInt32(numS[1].ToString())}");