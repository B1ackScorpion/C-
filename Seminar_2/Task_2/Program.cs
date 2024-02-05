// Задание 2
// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.

Console.Clear();
Console.Write("Введите 3-х значное число: ");
int n = int.Parse(Console.ReadLine()!);
n = Math.Abs(n); // Модуль числа
while (n < 100 || n > 999){
    Console.Write("Вы ошиблись!\nВведите 3-х значное число: ");
    n = int.Parse(Console.ReadLine()!);
}
int n3 = n % 10;
int n2 = (n % 100) / 10;
// Console.WriteLine(Math.Pow(n2, n3));
int result = 1;
for (int i = 0; i < n3; i++)
    result *= n2;

Console.WriteLine($"{n2}^{n3} = {result}");