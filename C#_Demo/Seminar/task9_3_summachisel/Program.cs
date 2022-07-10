/* Задача 67:** Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12
45 -> 9 */

using System;
using static System.Console;
Clear();

Write("Введите число ");
int number = Convert.ToInt32(ReadLine());
int sum = 0;

int Summa(int num)
{
    // if (num == 0) return 0;
    // return num % 10 + Summa(num / 10);
    if (num == 0) return sum;
    else
    {
        sum += num % 10;
        return Summa(num /= 10);
    }
}

Summa(number);
WriteLine($"Сумма = {sum}");