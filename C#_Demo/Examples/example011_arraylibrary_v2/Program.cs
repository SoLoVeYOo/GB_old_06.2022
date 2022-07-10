void HaveArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        Console.WriteLine(collection[index]);
        index++;
    }
}

int IndexOf(int[] collect, int find)
{
    int cou = collect.Length;
    int ind = 0;
    int posi = -1;
    while (ind < cou)
    {
        if (collect[ind] == find)
        {
            posi = ind;
            break;
        }
        ind++;
    }
    return posi;
}
int[] array = new int[5];

HaveArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);