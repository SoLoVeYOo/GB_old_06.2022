// Напишите программу, которая по заданному номеру координат, показывает в какой четверти находится данная четверть.

using System;
using static System.Console;
Console.Clear();

Console.WriteLine("Input x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Input y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 && y == 0) Console.WriteLine("Точка находится в начале координат");
if (x > 0 && y > 0) Console.WriteLine("1 четверть");
if (x < 0 && y > 0) Console.WriteLine("2 четверть");
if (x < 0 && y < 0) Console.WriteLine("3 четверть");
if (x > 0 && y < 0) Console.WriteLine("4 четверть");