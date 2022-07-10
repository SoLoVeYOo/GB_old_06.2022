/* Задача 69:** Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

using System;
using static System.Console;
Clear();

Write("Введите число A ");
int A = Convert.ToInt32(ReadLine());
Write("Введите число B ");
int B = Convert.ToInt32(ReadLine());

int itog = 1;

int Stepen(int num)
{
    if (num == 0) return itog;
    else
    {
        itog *= A;
        return Stepen(--num);
    }
}

/* int Stepen (int num)
{
    if(num==0) return 1;
    return A*(Stepen(--num));
} */

Stepen(B);
WriteLine($"Число {A} в степени {B} = {itog}");