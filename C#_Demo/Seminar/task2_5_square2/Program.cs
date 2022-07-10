//Являются ли одно из двух чисел квадратом другого

using System;
using static System.Console;
Console.Clear();

WriteLine("Input number one ");
int num1 = Convert.ToInt32(ReadLine());
WriteLine("Input number two ");
int num2 = Convert.ToInt32(ReadLine());
WriteLine(Math.Pow(num1, 2) == num2 || Math.Pow(num2, 2) == num1 ? "One of the numbers is the square of the other" : $"Neither number is a square of the other, squre {num1} = {Math.Pow(num1, 2)} squre {num2} = {Math.Pow(num2, 2)}");

/* Альтернатива
if (Math.Pow(num1, 2) == num2 ^ Math.Pow(num2, 2) == num1) Write("One of the numbers is the square of the other");
else Write($"Neither number is a square of the other, squre {num1} = {Math.Pow(num1, 2)} squre {num2} = {Math.Pow(num2, 2)}"); */