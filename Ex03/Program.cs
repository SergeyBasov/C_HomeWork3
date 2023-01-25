/* Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void CalculateСube(int number)
{
    int countNum = 1;
    Console.Write("Таблица кубов чисел: ");
    while (countNum <= number)
    {
        int result = countNum * countNum * countNum;
        Console.Write(result);
        if (countNum < number) 
        {
            Console.Write(", ");
        }
        countNum++;
    }
}

int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = GetNum("Введите натуральное число: ");

CalculateСube(number);
