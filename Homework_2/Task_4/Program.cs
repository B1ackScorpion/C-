// Задача 4.
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Clear();
Console.Write("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1){
    Console.Write("Число не является натуральным\nВведите натуральное число: ");
    n = int.Parse(Console.ReadLine()!);
}
int m = n;
int i = 1;
while (n > 10){
    while (m > 10){
        m /= 10;
        i *= 10;
    }
    Console.Write($"{m}, ");
    n -= m * i;
    m = n;
    i = 1;
}
Console.WriteLine(n);