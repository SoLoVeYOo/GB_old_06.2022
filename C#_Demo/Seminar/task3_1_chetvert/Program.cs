// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

using System;
using static System.Console;
Console.Clear();

Console.WriteLine("Input number: ");
int num = int.Parse(Console.ReadLine());

switch (num) //Перебирание вариантов
{
    case 1:
        {
            Console.WriteLine("x > 0, y > 0");
            break;
        }
    case 2:
        {
            Console.WriteLine("x < 0, y > 0");
            break;
        }
    case 3:
        {
            Console.WriteLine("x < 0, y < 0");
            break;
        }
    case 4:
        {
            Console.WriteLine("x > 0, y < 0");
            break;
        }
    default: //Если не встретился вариант (По умолчанию)
        {
            Console.WriteLine("Incorrect number");
            break;
        }
}