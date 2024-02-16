// Задание 3.
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.

bool checkVowel(char ch, char[] vowels){
    foreach (char element in vowels){
        if (element == ch)
            return true;
    }
    return false;
}

Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
char[] vowels = {'a', 'e', 'o', 'i', 'y', 'u'};
int count = 0;
for (int i = 0; i < str.Length; i++){
    if (checkVowel(str[i], vowels))
        count++;
}
Console.WriteLine(count);