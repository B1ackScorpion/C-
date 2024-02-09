// Задание 1.
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1001);
    }
}

bool IsPrime(int x)
{
    for (int i = 2; i <= x / 2; i++)
    {
        if (x % i == 0)
            return false;
    }
    return true;
}

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
foreach (int element in array)
{
    if (IsPrime(element))
        Console.Write($"{element} ");
}