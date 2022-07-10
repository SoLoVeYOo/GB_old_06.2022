using System;
using static System.Console;

string separator = ", ";
WriteLine("Введите строки через запятую c пробелом:");
string[] Array = Console.ReadLine().Split(separator).ToArray();
Write("Введите число для формирования массива строк по заданному числу символов: ");
int condition = Convert.ToInt32(ReadLine());

string[] ChangeArray(string[] array, int conditionNumber)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++) if (array[i].Length <= conditionNumber) number++;
    string[] result = new string[number];
    if (number > 0)
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= conditionNumber)
            {
                result[j] = array[i];
                j++;
            }
        }
    }
    return result;
}

string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++) result += $"'{array[i]}' ";
    result += "]";
    return result;
}

WriteLine(PrintArray(Array));
Array = ChangeArray(Array, condition);
WriteLine(PrintArray(Array));