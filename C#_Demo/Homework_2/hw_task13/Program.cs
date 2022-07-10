/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

using System;
using static System.Console;
Console.Clear();

WriteLine("Input number ");
int num = Convert.ToInt32(ReadLine());
string numS = num.ToString();
WriteLine(num / 100 > 0 ? $"{num} -> third number is {Convert.ToInt32(numS[2].ToString())}" : $"{num} -> there is no third digit");