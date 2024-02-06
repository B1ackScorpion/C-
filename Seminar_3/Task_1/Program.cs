// Задание 1
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.

 Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];   // [0, 0, ..., 0]
// double[] array = new double[n]; // [0.0, 0.0, ..., 0.0]
// string[] array = new string[n]; // ["", "", ..., ""]
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11); // [-10; 10]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

Console.Write("Введите искомый элемент: ");
int element = int.Parse(Console.ReadLine()!);
string result = "Нет";
for (int i = 0; i < array.Length; i++){
    if (array[i] == element)
        result = "Да";
}
Console.WriteLine(result);