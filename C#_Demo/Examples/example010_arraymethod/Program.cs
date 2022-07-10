int[] array = { 31, 222, 13, 34, 25, 16, 37, 34, 19 };

int n = array.Length; //длина массива
int find = 34;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //заканчиваем алгоритм когда найдем первый нужный элемент
    }
    index++;
}