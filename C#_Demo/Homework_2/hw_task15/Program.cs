/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

using System;
using static System.Console;
Console.Clear();

WriteLine("Input number ");
int num = Convert.ToInt32(ReadLine());
WriteLine(num == 6 | num == 7 ? $"{num} -> Yes, a day off" : $"{num} -> No, not a day off");