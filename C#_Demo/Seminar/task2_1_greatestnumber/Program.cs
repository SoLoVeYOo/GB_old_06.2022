// Случайное число из отрезка 10 - 99 и показывает наибольшую цифру числа

using System;
using static System.Console;
Console.Clear();

// Строчный способ

int num = new Random().Next(10, 100);
string numS = num.ToString();
int a1 = Convert.ToInt32(numS[0].ToString()); //пишем ToString принудительно чтобы показалось число а не его цифровой аналог
int a2 = Convert.ToInt32(numS[1].ToString());

/* Математический способ
int a1 = num / 10;
int a2 = num % 10; */

if (a1 > a2)
    WriteLine($"{num} -> {a1}");
else
    WriteLine($"{num} -> {a2}");