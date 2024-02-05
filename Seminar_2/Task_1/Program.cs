// Задание 1
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.

Console.Clear();
Console.Write("Введите 3-х значное число: ");
int n = int.Parse(Console.ReadLine()!);
n = Math.Abs(n); // Модуль числа
while (n < 100 || n > 999){
    Console.Write("Вы ошиблись!\nВведите 3-х значное число: ");
    n = int.Parse(Console.ReadLine()!);
}
int n1 = n / 100;
int n3 = n % 10;
Console.WriteLine(n1 * 10 + n3);
Console.WriteLine($"{n1}{n3}");