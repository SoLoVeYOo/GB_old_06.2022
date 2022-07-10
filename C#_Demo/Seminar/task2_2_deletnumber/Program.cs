// В трехзначном числе удалить вторую цифру

using System;
using static System.Console;
Console.Clear();

int num = new Random().Next(100, 1000);
string numS = num.ToString();
/*int a1 = Convert.ToInt32(numS[0].ToString());
int a2 = Convert.ToInt32(numS[2].ToString());
WriteLine($"{num} -> {a1}{a2}"); */
WriteLine($"{num} -> {Convert.ToInt32(numS[0].ToString())}{Convert.ToInt32(numS[2].ToString())}");

/* Математический способ
int a1 = num / 100;
int a2 = num % 10;
WriteLine($"{num} -> {a1}{a2}"); */