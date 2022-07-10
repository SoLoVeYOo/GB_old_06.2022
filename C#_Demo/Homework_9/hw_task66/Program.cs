/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using System;
using static System.Console;

Write("Введите число M ");
int M = Convert.ToInt32(ReadLine());
Write("Введите число N ");
int N = Convert.ToInt32(ReadLine());

int Summa(int num)
{
    if (num > N) return 0;
    return num + (Summa(++num));
}

WriteLine($"Сумма чисел в промежутке от M до N = {Summa(M)}");