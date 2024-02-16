// Задание 1. 
// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива.

Console.Clear();
Console.Write("Кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
char[] chars = new char[n];
for (int i = 0; i < chars.Length; i++){
    Console.Write("Введите элемент массива: ");
    chars[i] = char.Parse(Console.ReadLine()!);
}
Console.WriteLine($"Начальный массив: [{string.Join(", ", chars)}]");
Console.WriteLine(string.Join("", chars));
string result = "";
foreach (char element in chars){
    result += element;
}
Console.WriteLine(result);
