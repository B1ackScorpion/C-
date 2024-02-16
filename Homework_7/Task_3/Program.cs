// Задача 3.
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int ReverseArray(int[] array, int i)
{
    if (i < 1)
    {
        Console.Write($"{array[0]}");
        return array[0];
    }
    Console.Write($"{array[i]}, ");
    return ReverseArray(array, i - 1);
}

Console.Clear();
int[] array = new int[new Random().Next(1, 11)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}
Console.WriteLine($"Изначальный массив : [{string.Join(", ", array)}]");
ReverseArray(array, array.Length - 1);