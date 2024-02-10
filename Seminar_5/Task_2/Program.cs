// Задание 2.
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0.0); (1.1)) и т.д.

using System.Xml.XPath;

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

int sumElements(int[,] matrix)
{
    int x = matrix.GetLength(0), y = matrix.GetLength(1);
    int result = 0;
    if (x < y)
    {
        for (int i = 0; i < x; i++)
            result += matrix[i, i];
    }
    else
    {
        for (int i = 0; i < y; i++)
            result += matrix[i, i];
    }
    return result;
}

Console.Clear();
Console.Write("Введите размеры 2D массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
inputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
printMatrix(matrix);
Console.WriteLine($"Сумма элементов главной диагонали равна {sumElements(matrix)}");