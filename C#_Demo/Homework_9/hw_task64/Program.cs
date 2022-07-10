/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа по убыванию в промежутке от M до N.

M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 5, 4" */

using System;
using static System.Console;

Write("Введите число M ");
int M = Convert.ToInt32(ReadLine());
Write("Введите число N ");
int N = Convert.ToInt32(ReadLine());

string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (end + " " + GetNumbers(start, --end));
}

WriteLine(GetNumbers(M, N));