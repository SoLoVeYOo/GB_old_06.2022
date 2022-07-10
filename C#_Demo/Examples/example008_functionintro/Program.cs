int Max(int arg1, int arg2, int arg3) //функция поиска максимального числа из 3-х
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; //возвращаем результат функции
}
int a1 = 34;
int b1 = 101;
int c1 = 6669;
int a2 = 7889;
int b2 = 44;
int c2 = 63358;
int a3 = 71;
int b3 = 42;
int c3 = 4444;

/* int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3); */

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.Write("max = ");
Console.WriteLine(max);

/* int a1 = 34;
int b1 = 101;
int c1 = 66;
int a2 = 78;
int b2 = 44;
int c2 = 63;
int a3 = 71;
int b3 = 42;
int c3 = 68;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;
Console.Write("max = ");
Console.WriteLine(max); */