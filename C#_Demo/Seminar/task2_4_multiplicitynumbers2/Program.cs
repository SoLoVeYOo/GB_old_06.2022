// Проверить кратность числа на 7 и на 23 одновременно

using System;
using static System.Console;
Console.Clear();

WriteLine("Input number ");
int num = Convert.ToInt32(ReadLine());
int a = 7, b = 23;
WriteLine(num % a == 0 && num % b == 0 ? "The number is a multiple of the 7 & 23" : $"The number is not a multiple of the 7 & 23, remainder 7 = {num % a} remainder 23 = {num % b}");

/* Альтернатива
if (num % a == 0 && num % b == 0) Write("The number is a multiple of the 7 & 23");
else Write($"The number is not a multiple of the 7 & 23, remainder 7 = {num % a} remainder 23 = {num % b}"); */