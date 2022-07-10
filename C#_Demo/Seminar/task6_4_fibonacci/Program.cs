/* Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
а мы берем два любых жругих значения
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

using System;
using System.Linq;
using static System.Console;
Clear();

WriteLine("Input number");
int N = Convert.ToInt32(ReadLine());
WriteLine("Input number a1");
int a1 = Convert.ToInt32(ReadLine());
WriteLine("Input number a1");
int a2 = Convert.ToInt32(ReadLine());

// 1-й вариант через массив
int[] fib = new int[N];
fib[0] = a1;
fib[1] = a2;
for (int i = 2; i < fib.Length; i++)
{
    fib[i] = fib[i - 1] + fib[i - 2];
}
WriteLine(string.Join(" ", fib));

/* 2-ой вариант - через метод 
void Furye(int n1, int n2, int M)
{
    if (N >= 0) Write(n1 + " ");
    if (N >= 1) Write(n2 + " ");
    for (int i = 0; i < N - 2; i++)
    {
        n2 += n1;
        n1 = n2 - n1;
        Write(n2 + " ");
    }
}
Furye(a1, a2, N); */

/* 3-ий вариант - через простой цикл
Write($"{a1} {a2}");
for (int i = 0; i < N - 2; i++)
 {
    int b = a1 + a2;
    Write($" {b}");
    a1 = a2;
    a2 = b;
}



/* алгоритм Фибоначи
WriteLine("Input number");
int N = Convert.ToInt32(ReadLine());
int[] fib = new int[N];
fib[0] = 0;
fib[1] = 1;
for (int i = 2; i < fib.Length; i++)
{
    fib[i] = fib[i - 1] + fib[i - 2];
}
WriteLine(string.Join(" ", fib)); */