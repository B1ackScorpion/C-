// Задание 1.
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

int sumNumber(int n)
{
    if (n / 10 == 0 || n % 10 == n)
        return n;
    return sumNumber(n / 10) + n % 10;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(sumNumber(n));