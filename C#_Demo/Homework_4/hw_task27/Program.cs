/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

using System;
using static System.Console;

/* Write("Input number: ");
string? number = ReadLine();
int lenght = number.Length;
int summa = 0;
for (int i = 0; i < lenght; i++)
{
    summa = summa + Convert.ToInt32(number[i].ToString());
}
WriteLine($"{number} - > {summa}"); */

int Method(string num)
{
    int lenght = num.Length;
    int summa = 0;
    for (int i = 0; i < lenght; i++)
    {
        summa = summa + Convert.ToInt32(num[i].ToString());
    }
    return summa;
}
int sum = Method(Convert.ToString(ReadLine()));
Write($" -> {sum}");