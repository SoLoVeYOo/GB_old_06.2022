//При вводе числа выдается какой день недели

using System;
using static System.Console;

Write("Input number ");
int number = int.Parse(ReadLine()); //можно int number = Convert.ToInt32(ReadLine());
if (number == 1)
{
    WriteLine("Monday");
}
if (number == 2)
{
    WriteLine("Tuesday");
}
if (number == 3)
{
    WriteLine("Wednesday");
}
if (number == 4)
{
    WriteLine("Thursday");
}
if (number == 5)
{
    WriteLine("Friday");
}
if (number == 6)
{
    WriteLine("Saturday");
}
if (number == 7)
{
    WriteLine("Sunday");
}
if (number > 7)
{
    WriteLine("Incorrect number");
}
if (number < 1)
{
    WriteLine("Incorrect number");
}