/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */

using System;
using static System.Console;

WriteLine("Input number ");
int num = Convert.ToInt32(ReadLine());
string numT = num.ToString();
WriteLine(Convert.ToInt32(numT[0].ToString()) == Convert.ToInt32(numT[4].ToString()) && Convert.ToInt32(numT[1].ToString()) == Convert.ToInt32(numT[3].ToString()) ? "Число является палиндромом" : "Число не является палиндромом");