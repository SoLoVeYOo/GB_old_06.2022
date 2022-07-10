int[] CreateArray(int size) 
{
    return new int[size];
}
void Fill(int[] array, int min, int max) 
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
int[] SolveEx(int[] array) 
{
    int size = array.Length;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[i];
    }
    return result;
}
void NotTruePrint(int[] array) 
{
    int size = array.Length;
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine(array[i]);
    }
}

string TruePrint(int[] array) 
{
    string res =string.Empty;
    int size = array.Length;
    res = "[ ";        
    for (int i = 0; i < size; i++)
    {
        res += $"{array[i],3} ";
    }
    res += "]";        

    return res;
}

int[] startArray = CreateArray(10);
// System.Console.WriteLine(TruePrint(startArray));
// File.WriteAllText("file.txt",TruePrint(a));
Fill(startArray, 1, 10);
System.Console.WriteLine(TruePrint(startArray));
int[] resultArray = SolveEx(startArray);
System.Console.WriteLine(TruePrint(resultArray));