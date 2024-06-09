// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]




char[] StringToCharArray(string st)
{
    char[] arrStr = new char[st.Length];
    for (int i = 0; i < st.Length; i++)
    {
        arrStr[i] = st[i];
    }
    return arrStr;
}

void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        Console.Write($"{array[i]}, ");
        else
        Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

Console.WriteLine("Type something: ");
string str = Console.ReadLine();

char[] result = StringToCharArray(str);
PrintArray(result);