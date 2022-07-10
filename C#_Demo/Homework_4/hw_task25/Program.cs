/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

using System;
using static System.Console;

int Method(int A, int B)
{
   int result = A;
   for (int i = 2; i <= B; i++)
   {
      result = result * A;
   }
   return result;
}
int res = Method(Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));
WriteLine(res);

/*
Write("Input number A = ");
int A = Convert.ToInt32(ReadLine());
Write("Input number B = ");
int B = Convert.ToInt32(ReadLine());
int result = A;
for (int i = 2; i <= B; i++)
{
   result = result * A;
}
WriteLine($"{A}, {B} -> {result}"); */