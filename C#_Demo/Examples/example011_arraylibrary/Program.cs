/* функция без возврата какого-либо элемента
   2 функции: поиска 10 рандомных значений массива и вывода их на экран
   их можно объеденить!

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array); */

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collect, int find)
{
    int cou = collect.Length;
    int ind = 0;
    int posi = -1; //ставим -1 чтобы было наглядно видно что данного элемента в массиве нет
    while (ind < cou)
    {
        if (collect[ind] == find)
        {
            posi = ind;
            break; //остановится после первого нужного нам элемент (иначе будет показывать последний, если таковых несколько)
        }
        ind++;
    }
    return posi; //возвращаем элемент
}
int[] array = new int[10]; //массив из 10 чисел

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);