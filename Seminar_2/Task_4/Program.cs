// Задание 4
// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
n = Math.Abs(n);
if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else{
    int x = n % 1000;
    Console.WriteLine(x / 100);
}