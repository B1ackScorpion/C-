// Задача 3. 
// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

bool IsPalindrome(string str)
{
    str = str.ToLower();
    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
    {
        if (str[i] != str[j])
            return false;
    }
    return true;
}

// bool IsPalindrome(string str)
// {
//     string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
//     return normalized.SequenceEqual(normalized.Reverse());
// }

Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
if (IsPalindrome(str))
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");


