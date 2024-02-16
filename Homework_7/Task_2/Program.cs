// Задача 2.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int IsPositive(int n)
{
    int m = n;
    while (m < 0)
    {
        Console.Write("Число должно быть неотрицательным. Введите заного число: ");
        m = int.Parse(Console.ReadLine()!);
    }
    return m;
}

int Akker(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akker(m - 1, 1);
    return Akker(m - 1, Akker(m, n - 1));
}

Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
m = IsPositive(m);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
n = IsPositive(n);
Console.WriteLine(Akker(m, n));
