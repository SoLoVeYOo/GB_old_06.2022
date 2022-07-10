/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29 */

using System;
using static System.Console;

Write("Введите число m ");
int m = Convert.ToInt32(ReadLine());
Write("Введите число n ");
int n = Convert.ToInt32(ReadLine());

int Akkerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num1 != 0 && num2 == 0) return Akkerman(num1 - 1, 1);
    if (num1 > 0 && num2 > 0) return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
    return num2 + 1;
}

WriteLine($"Функция Аккермана A({m},{n}) = {Akkerman(m, n)}");