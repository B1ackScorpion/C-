// Задача 1.
// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

string NumBetweenMN(int m, int n)
{
    if (n <= m)
        return $"{m}, ";
    return NumBetweenMN(m, n - 1) + $"{n}, ";
}

Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
while (n <= m)
{
    Console.Write("Второе число должно быть больше первого. Введите заного второе число: ");
    n = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(NumBetweenMN(m, n));