// Задача 3.
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Clear();
Console.Write("Введите целое число из отрезка [10, 99]: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 10 || n > 99){
    Console.Write("Значение числа не входит в заданный отрезок\nВведите целое число из отрезка [10, 99]: ");
    n = int.Parse(Console.ReadLine()!);
}
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
    Console.WriteLine($"Наибольшая цифра {n1}");
else if (n1 < n2)
    Console.WriteLine($"Наибольшая цифра {n2}");
else
    Console.WriteLine($"Одинаковые цифры {n1}");