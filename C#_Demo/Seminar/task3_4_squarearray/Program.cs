//Написать программу которая будет выводить квадраты числе от 1 до N

using System;
using static System.Console;
Console.Clear();

WriteLine("Input number ");
int N = Convert.ToInt32(ReadLine());
int index = 1;
Write($"{N} ->");
while (index <= N)
{
    Write($" {Math.Pow(index, 2)}");
    index++;
}

/* Ввод ненсколько данных с одной строки
string [] p = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries); - условие разделения (убираем пустоты из массива)
Console.WriteLine($"{p[0]}); - получается массив и берем данные через индекс */