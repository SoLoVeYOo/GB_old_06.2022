# **Контрольная работа**
### **Студента:** 
***Соловушкова Дмитрия Сергеевича***  
[Ссылка на репозиторий](https://github.com/SoLoVeYOo/examination)

## **Задание**
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

*Примеры:* 
* ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
* ["1234", "1567", "-2", "computer science"] -> ["-2"]
* ["Russia", "Denmark", "Kazan"] -> []

**Что необходимо учесть при выполнении контрольной работы:**

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

## **Описание решения**
1. Создание файла README.md для оформления текстового описания решения
2. Создание блок-схемы, где описывается алгоритм решения данного задания
> Обозначения:
> * Array() - заданный массив строк
> * i = 0 - индекс заданного массива
> * condition - переменная условия
> * len = lenght(Array) - длина заданного массива
> * lenElement = lenght(Array[i]) - длина элемента c индексом i заданного массива
> * ResultArray = new array() - новый формируемый массив
> * j = 0 - индекс нового формируемого массива

Алгоритм заключается в том, что каждый элемент заданого массива проверяется на условие (его длина меньше или равна 3). Затем если данный элемент удовлитворяет данному условию, то он записывается в новый формирующийся массив под индексом "0", затем увеличиваем индекс нового массива "j" на 1 (чтобы записать следующий, удовлитворивший условию элемент уже под новым индексом) и индекс заданного массива "i" на 1. Если данный элемент не удовлитворяет данному условию, то сразу увеличиваем индекс заданного массива "i" на 1. Затем следующий элемент заданного массива проверяем на условие и так далее, пока не будут проверены все элементы заданного массива.

3. Создание файла программы в репозитории
4. Написание программы для решения данной задачи (написание программы будет выполнятся поэтапно с описание каждой версии):
* program v0.1
> ввод массив и проверка работы цикла по нахождению элементов в заданном массиве строк с длиной меньше либо равное 3  
[ссылка на v0.1](https://github.com/SoLoVeYOo/examination/commit/49fd62feed6e659db8620bb83b2730882bc50e0b)

* program v0.2
> создание метода "FindColString" по нахождению элементов в заданном массиве строк с длиной меньше либо равное 3 с проверкой его работы  
[ссылка на v0.2](https://github.com/SoLoVeYOo/examination/commit/5354c0c51915c7d3b21e805f86dc31c805308859)

* program v0.25
> в процессе создание метода "ChangeArray" выяснялось что не получается создать заведомо пустой массив, а потом уже добавлять туда элементы (не хватает знания синтаксиса языка). Вследствии чего принято решение находить количество удовлетворяющих условию элементов в заданном массиве, для нахождения длины нового массива  
[ссылка на v0.25](https://github.com/SoLoVeYOo/examination/commit/f8b496a36e141d5f507b24fca18df96ee995bb91)

* program v0.3
> рабочий метод "ChangeArray" по нахождению элементов в заданном массиве строк с длиной меньше либо равное 3 с проверкой его работы  
[ссылка на v0.3](https://github.com/SoLoVeYOo/examination/commit/a9d8c671d13b94971c34558551b4f9f9fc71f6be)

* program v0.4
> добваление метода "PrintArray" для вывода массивов и упрощения проверки алгоритма работы программы. Рабочая версия программы  
[ссылка на v0.4](https://github.com/SoLoVeYOo/examination/commit/e02cbeeeeb1fcc31903f015b55daa5b18aa6abaf)

* program v0.5
> добваление переменной "condition" и переработка метод "ChangeArray" (были убраны "магические числа"). Выполнены космитические правки для уменьшения кода  
[ссылка на v0.5](https://github.com/SoLoVeYOo/examination/commit/858dfcc572b7d2b7fbea3f77625b11c3eb7d5929)

* program v1.0
> добавление реализации возможности ввода массива строк и числа для условия с клавиатуры. Добваление переменной "separator" для удобного ввода с клавиатуры  
[ссылка на v1.0](https://github.com/SoLoVeYOo/examination/commit/94d01f8eff541a654d8215a6deb3709f9edefa9c)

* program v1.1
> программа переработана для перезаписи уже имеющегося массива. Итоговая версия

## **Пояснительная записка**
* В программе не использовались переменные "len" и "lenElement", т.к. синтаксис языка c# позволял их не использовать и заменить на "array.Lenght" и "array[i].Lenght" соотвественно. В блок-схему имзенения не вносились, т.к. она описывает общий алгоритм и не учитывает особенности языка программирования.

* В программу была добавлена дополнительная переменная "separator" для упрощения ввода с клаивиатуры, и она не отабрежена в блок-схеме, т.к. носит исключительно синтаксическую составляющую. Дополнительную переменную можно было не использовать, но тогда бы приходилось вводить строки только через запятую.

* В программу добавлен метод по выводу строк массивов "PrintArray", что не было условием в задачи. Метод был добавлен для упрощения визуализации работоспособности программы.  
Программный код без данного метода:
 ```csharp
using System;  
using static System.Console;

string separator = ", ";  
WriteLine("Введите строки через запятую c пробелом:");  
string[] Array = Console.ReadLine().Split(separator).ToArray();  
Write("Введите число для формирования массива строк по заданному числу символов: ");  
int condition = Convert.ToInt32(ReadLine());  

string[] ChangeArray(string[] array, int conditionNumber)
{  
    int number = 0;  
    for (int i = 0; i < array.Length; i++) if (array[i].Length <= conditionNumber) number++;  
    string[] result = new string[number];  
    if (number > 0)  
    {  
        int j = 0;  
        for (int i = 0; i < array.Length; i++)  
        {  
            if (array[i].Length <= conditionNumber)  
            {  
                result[j] = array[i];  
                j++;  
            }  
        }  
    }  
    return result;  
}
Array = ChangeArray(Array, condition);
 ```

* Также в условия задачи неявно отражено, нужно ли сформировать новый массив или перезаписать уже имеющийся. В программе отражен код с перезаписью массива. 
Код программы с выводом нового массива:
 ```csharp
using System;
using static System.Console;

string separator = ", ";
WriteLine("Введите строки через запятую c пробелом:");
string[] Array = Console.ReadLine().Split(separator).ToArray();
Write("Введите число для формирования массива строк по заданному числу символов: ");
int condition = Convert.ToInt32(ReadLine());

string[] ChangeArray(string[] array, int conditionNumber)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++) if (array[i].Length <= conditionNumber) number++;
    string[] result = new string[number];
    if (number > 0)
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= conditionNumber)
            {
                result[j] = array[i];
                j++;
            }
        }
    }
    return result;
}

string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++) result += $"'{array[i]}' ";
    result += "]";
    return result;
}

WriteLine(PrintArray(Array));
string[] ResultArray = ChangeArray(Array, condition);
WriteLine(PrintArray(ResultArray));
 ```
Разница в коде, как видно несущественная.