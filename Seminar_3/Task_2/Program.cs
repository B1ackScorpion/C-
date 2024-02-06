// Задание 2
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11); // [-10; 10]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i++)
    array[i] *= -1;
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");