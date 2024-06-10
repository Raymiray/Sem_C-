// Считать строку с консоли, содержащую латинские
// буквы. Вывести на экран согласные буквы этой
// строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void PrintConsonantLetters(string txt, int index = 0)
{

    if (index == txt.Length) return;
    ChekConsonant(txt, index);
    PrintConsonantLetters(txt, index + 1);

}

void ChekConsonant(string txt, int index)
{
    string vowels = "aeyuio";
    if (char.IsAsciiLetter(txt[index]) && !vowels.Contains(txt[index]))
    {
        Console.Write($"{txt[index]} ");
    }
}

Console.WriteLine("Enter a string containing Latin letters: ");
string text = Console.ReadLine();

PrintConsonantLetters(text);