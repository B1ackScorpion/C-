// Задача 3
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.

void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}

int createNumber(int[] array)
{
    int resultNumber = 0, count = array.Length - 1;
    for (int i = 0; i < array.Length; i++)
    {
        resultNumber += array[i] * Convert.ToInt32(Math.Pow(10, count));
        count--;
    }
    return resultNumber;
}

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = int.Parse(Console.ReadLine()!);
while (n > 8)
{
    Console.Write("Вы ошиблись!\nВведите кол-во чисел: ");
    n = int.Parse(Console.ReadLine()!);
}
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(createNumber(array));