// Проверить кратность первого числа второму

using System;
using static System.Console;
Console.Clear();

WriteLine("Input number one ");
int num1 = Convert.ToInt32(ReadLine());
WriteLine("Input number two ");
int num2 = Convert.ToInt32(ReadLine());
/* if (num1 % num2 == 0) Write("The first number is a multiple of the second");
else Write("The first number is not a multiple of the second"); */

/* Тернарный оператор (условие -> ?"истина" :"ложь") - всегда что-то выдает
string answer = num1 % num2 == 0 ? "The first number is a multiple of the second" : $"The first number is not a multiple of the second, remainder = {num1 % num2}";
WriteLine(answer); */
WriteLine(num1 % num2 == 0 ? "The first number is a multiple of the second" : $"The first number is not a multiple of the second, remainder = {num1 % num2}");