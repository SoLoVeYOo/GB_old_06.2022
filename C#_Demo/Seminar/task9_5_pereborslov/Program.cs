using System;
using static System.Console;

string text1 = "i am lord voldemort";
string text2 = "tom marvolo rid1dle";

/* string newText1 = String.Join("", text1.ToLower().Replace(" ","").OrderBy(c => c).ToArray());
string newText2 = String.Join("", text2.ToLower().Replace(" ","").OrderBy(c => c).ToArray());
if (newText.Equals(newText2)) WriteLine("Да");
else WriteLine("Нет"); */

text1 = text1.Replace(" ","").ToLower();
text2 = text2.Replace(" ","").ToLower();

string TextSort(string t)
{
    char[] charArray = t.ToCharArray();
    Array.Sort(charArray);
    string newText = new String(charArray);
    return newText;
}
WriteLine(TextSort(text1) == TextSort(text2) ? "Да" : "Нет");