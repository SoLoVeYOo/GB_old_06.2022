/* Задача 65:** Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8" */

using System;
using static System.Console;
Clear();

Write("Введите число M ");
int M = Convert.ToInt32(ReadLine());
Write("Введите число N ");
int N = Convert.ToInt32(ReadLine());

string GetNumbers(int start, int end)
{
    if (start > end)
    {
        int temp = start;
        start = end;
        end = temp;
    }
    if (start == end) return start.ToString();
    return (start + " " + GetNumbers(start + 1, end));
}

string result = GetNumbers(M, N);
WriteLine(result);