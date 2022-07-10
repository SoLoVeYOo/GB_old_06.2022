// Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

using System;
using System.Linq;
using static System.Console;
Clear();

WriteLine("Input number");
int N = Convert.ToInt32(ReadLine());
string s = string.Empty;
while (N > 0)
{
    s = N % 2 + s;
    N = N / 2;
}
WriteLine($"{s}");

// WriteLine(Convert.ToString(Convert.ToInt32(ReadLine()), 2)); - альтернативный метод

/* униварсальное решение
using System;
Console.WriteLine(DecToNum(10,16));

string DecToNum(int decNumber, int otherSystem)
{
    string res="";
    string nums="0123456789ABCDEF";
    while(decNumber>0)
        {
        int ost=decNumber/otherSystem;
        res=nums[decNumber-otherSystem*ost]+res;
        decNumber/=otherSystem;
        }
    return res;
}
*/