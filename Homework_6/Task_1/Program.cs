// Задача 1.
// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

Console.Clear();
Console.Write("Введите размер двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
char[,] chars = new char[size[0], size[1]];
Random rnd = new Random();
for (int i = 0; i < chars.GetLength(0); i++)
{
    for (int j = 0; j < chars.GetLength(1); j++)
    {
        chars[i, j] = Convert.ToChar(rnd.Next('a', 'a' + 26));
        Console.Write($"{chars[i, j]}\t");
    }
    Console.WriteLine();
}
string str = ("");
for (int i = 0; i < chars.GetLength(0); i++)
{
    for (int j = 0; j < chars.GetLength(1); j++)
    {
        str += chars[i, j];
    }
}
Console.WriteLine(str);