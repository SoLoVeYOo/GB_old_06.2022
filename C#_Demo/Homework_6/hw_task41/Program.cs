/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

using System;
using System.Linq;
using static System.Console;

int[] M = ReadLine().Split().Select(int.Parse).ToArray();
int col = 0;
for (int i = 0; i < M.Length; i++)
{
    if (M[i] > 0) col++;
}
WriteLine($"Количество чисел больше 0 = {col}");