/* Задача 19 Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void PalindromCheck(int x)
{
    if (x / 10000 == x % 10 && (x % 10000) / 1000 == (x % 100) / 10)
    {
        Console.Write($"{x} да, это число палиндром");
    }
    else
    {
        Console.Write($"{x} нет, это число не палиндром");
    }
}

int GetNum(string text)
{
    Console.Write(text);
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x = GetNum("Введите натуральное пятизначное число: ");

PalindromCheck(x);