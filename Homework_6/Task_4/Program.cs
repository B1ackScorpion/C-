// Задача 4*(не обязательная). 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string StrReverse(string str)
{
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}

Console.Clear();
string str = ("Hello my world");
Console.WriteLine(str);
Console.WriteLine(StrReverse(str));

