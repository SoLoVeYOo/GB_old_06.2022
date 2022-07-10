//Написать программу которая будет считать длину отрезка на координатной плоскасти

using System;
using static System.Console;
Console.Clear();

Console.WriteLine("Input x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Input y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Длинна отрезка = {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");