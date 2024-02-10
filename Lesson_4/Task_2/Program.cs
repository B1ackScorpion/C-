int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rng = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rng.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}

bool IsInteresting(int value)
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0)
        return true;
    return false;
}

int[,] matrix = CreateMatrix(3,4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (IsInteresting(e))
    {
        Console.WriteLine(e);
    }
}
