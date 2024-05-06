// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли первое число кратным второму.
// Если первое число не кратно второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.Write("Введите первое целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое положительное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = num1 % num2;

if (remainder == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine($"No, {remainder}");
}
