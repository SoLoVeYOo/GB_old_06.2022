//Найти квадрат числа

using System;
using static System.Console; //позволяет не писать в дальнейшем слова Console

Write("Введите число ");
double number = double.Parse(ReadLine()); //будет писать ошибку что не предумсотрено, если в строке ничего не введется
double square = number * number;
// или square = Convert.ToInt32(Math.Pow(number,2));
Write($"Квадрат числа = {square}"); //$ позволяет писать переменную в {}