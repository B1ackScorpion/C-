// Задание 2
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

string printNumbers(int n)
{
    if (n == 1)
        return "1 ";
    return printNumbers(n - 1) + $"{n} ";
}
/* f = printNumbers
f(5) -> f(4) + "5 " = "1 2 3 4 5 "
        |
        f(3) + "4 "
        |
        f(2) + "3 "
        |
        f(1) + "2 "
        |
        "1 "


/* f = printNumbers
f(5) -> "5 " + f(4)
               |
               "4 " + f(3) = "5 4 " + f(3)
                      |
                      "3 " + f(2) = "5 4 3 " + f(2)
                             |
                             "2 " + f(1) = "5 4 3 2" + f(1)
                                    |
                                    "1 " = "5 4 3 2 1 "
*/

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumbers(n));