// Задача 2.
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите кол-во чисел");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
int count = EvenNumbers(array);
Console.WriteLine($"Ссозданный массив: [{string.Join(", ",array)}]");
Console.WriteLine($"Кол-во четных чисел в массиве: {count}");