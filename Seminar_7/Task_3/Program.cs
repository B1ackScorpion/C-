// Задание 3
// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.

string printConsonants(string n, int i)
{
    if (i == n.Length)
        return "";
    else
    {
        if (n[i] == 'a' || n[i] == 'e' || n[i] == 'y' || n[i] == 'u' || n[i] == 'o'
        || n[i] == 'i')
            return printConsonants(n, i + 1);
        return n[i] + printConsonants(n, i + 1);
    }
}
/*
n = 10
m = 20
10 + 20 = 30
Console.WriteLine(n + " + " + m + "=" + n + m); 
Console.WriteLine($"{n} + {m} = {n + m}"); // -> "10"
*/

Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
Console.WriteLine(printConsonants(str, 0));
