/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

using System;
using static System.Console;

Write("Input number b1 = ");
double b1 = Convert.ToDouble(ReadLine());
Write("Input number k1 = ");
double k1 = Convert.ToDouble(ReadLine());
Write("Input number b2 = ");
double b2 = Convert.ToDouble(ReadLine());
Write("Input number k2 = ");
double k2 = Convert.ToDouble(ReadLine());

if (k1 == k2 && b1 == b2) WriteLine("Графики функций совпадают");
if (k1 == k2 && b1 != b2) WriteLine("Графики функций не пересекаются (параллельные прямые)");
if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    WriteLine(y1 == y2 ? $"Точка пересечения функций - ({x} ; {y1})" : "Ошибка данных");
}