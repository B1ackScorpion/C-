// Задача 3. 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void NewArray (int[] array)
{
    int m = array.Length - 1;
    int k = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        k = array[i];
        array[i] = array[i+m];
        array[i+m] = k;
        m -= 2;
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Ссозданный массив: [{string.Join(", ", array)}]");
NewArray(array);
Console.WriteLine($"Перевернутый массив: [{string.Join(", ", array)}]");