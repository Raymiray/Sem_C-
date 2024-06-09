// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountVowels(string str)
{
    string vowels = "aeyuio";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (vowels[j] == str[i])
            {
                count++;
            }
        }
    }
    return count;
}


Console.WriteLine("Enter some word: ");
string start = Console.ReadLine();
System.Console.WriteLine($"In word {CountVowels(start)} vowels: ");