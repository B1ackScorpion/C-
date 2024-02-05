// Задача 2. 
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите значение координаты X отличное от 0: ");
int x = int.Parse(Console.ReadLine()!);
while (x == 0){
    Console.Write("Значение координаты не должно равняться 0.\nВведите значение координаты X отличное от 0: ");
    x = int.Parse(Console.ReadLine()!);
}
Console.Write("Введите значение координаты Y отличное от 0: ");
int y = int.Parse(Console.ReadLine()!);
while (y == 0){
    Console.Write("Значение координаты не должно равняться 0.\nВведите значение координаты Y отличное от 0: ");
    y = int.Parse(Console.ReadLine()!);
}
if (x > 0 && y > 0)
    Console.WriteLine("1");
else if (x < 0 && y > 0)
    Console.WriteLine("2");
else if (x < 0 && y < 0)
    Console.WriteLine("3");
else if (x > 0 && y < 0)
    Console.WriteLine("4");
