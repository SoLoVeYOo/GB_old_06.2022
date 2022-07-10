/* Вид 1 - ничего не возвращает и ничего не принимает
void Method1()
{
    Console.WriteLine("Autor ...");
} 
Method1(); */

/* Вид2 - ничего не возвращает, но принимает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Text message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Text", 4);
//Method21(msg: "Text", count: 4);
Method21(count: 4, msg: "New text"); */

/* Вид 3 - возвращает, но ничего не принимает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); */

// Вид 4 - возвращает и принимает
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "text");
Console.WriteLine(res);