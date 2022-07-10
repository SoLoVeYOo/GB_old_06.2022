int Max(int arg1, int arg2, int arg3) //функция поиска максимального числа из 3-х
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; //возвращаем результат функции
}
int[] array = {31,222,13,34,25,16,37,28,19};

// array[0] = 12;

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.Write("max = ");
Console.WriteLine(max);