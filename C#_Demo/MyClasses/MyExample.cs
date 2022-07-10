namespace MyClasses;
using System;

public class MyExample
{
    ///<Summary>
    ///Создание массива от min до max
    ///</Summary>
    public static int[,] GetArray(int rows, int colums, int min, int max)
    {
        int[,] result = new int[rows, colums];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                result[i, j] = new Random().Next(min, max);
                Console.Write($"{result[i, j]} ");
            }
            Console.WriteLine();
        }
        return result;
    }

    ///<Summary>
    ///Создание массива от 0 до max
    ///</Summary>
    public static int[,] GetArray(int rows, int colums, int max)
    {
        int[,] result = new int[rows, colums];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                result[i, j] = new Random().Next(0, max);
                Console.Write($"{result[i, j]} ");
            }
            Console.WriteLine();
        }
        return result;
    }
}