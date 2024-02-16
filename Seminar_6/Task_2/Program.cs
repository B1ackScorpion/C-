// Задание 2.
//На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
char[] chars = new char[str.Length];
for (int i = 0; i < str.Length; i++){
    chars[i] = str[i];
}
Console.WriteLine($"Результат: [{string.Join(", ", chars)}]");