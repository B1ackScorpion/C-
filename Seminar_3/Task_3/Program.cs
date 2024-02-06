// Задание 3
// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int[] resultArray = new int[array.Length / 2];
for (int i = 0; i < array.Length / 2; i++)
    resultArray[i] = array[i] * array[array.Length - 1 - i];
Console.WriteLine($"Конечный массив: [{string.Join(", ", resultArray)}]");