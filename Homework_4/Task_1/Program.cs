// Задача 1. 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int EvenNumber(string symbol)
{
    
    if (int.TryParse(symbol, out int number)) 
    {
        int sum = 0;
        while( number > 0)
        {
        sum+= number % 10;
        number /= 10;
        }
        return sum;
    }
    return 1;
}

string EnterSymbol()
{
    Console.WriteLine("Введите символ с клавиатуры: ");
    string symbol = Console.ReadLine()!;
    return symbol;
}

Console.Clear();
while (true)
{
    string symbol = EnterSymbol();
    if (EvenNumber(symbol) % 2 == 0 || symbol == "q")
    {
        Console.WriteLine("STOP");
        break; 
    }      
}
