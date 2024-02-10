// void inputArray(double[] array){
// for (int i = 0; i < array.Length; i++){
// array[i] = Math.Round(20 * new Random().NextDouble() - 10, 2); // (-10; 10)
// // NextDouble() - генерирует число в диапазоне (0; 1)
// // Math.Round(число, кол-во знаков после запятой)
// // x (0; 1)
// // 20 * x (0; 20)
// // 20 * x - 10 (-10; 10)
// }
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n]; // [0.0, 0.0, 0.0, ..., 0.0]
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// Задание 1.
// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.

void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t"); // \t - табуляция
        }
        Console.WriteLine();
    }
}

void replaceElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(0); j+=2)
        {
            matrix[i,j] *= matrix[i,j];
        }
    }
}

Console.Clear();
Console.Write("Введите размеры 2D массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
inputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
printMatrix(matrix);
replaceElements(matrix);
Console.WriteLine("\nКонечный массив: ");
printMatrix(matrix);
