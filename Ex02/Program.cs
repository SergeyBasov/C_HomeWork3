/* Задача 21 Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    Console.Write("Дистанция между координатами: ");
    double result1 = (x2 - x1) * (x2 - x1);
    double result2 = (y2 - y1) * (y2 - y1);
    double result3 = (z2 - z1) * (z2 - z1);
    double result = Math.Sqrt(result1 + result2 + result3);
    Console.Write(result);
}

double GetDouble(string text)
{
    Console.Write(text);
    double num = double.Parse(Console.ReadLine());
    return num;
}

// Ввод данных от пользователя первой и второй точки в 3D
double x1 = GetDouble("Введите значение X первой точки: ");
double y1 = GetDouble("Введите значение Y первой точки: ");
double z1 = GetDouble("Введите значение Z первой точки: ");
double x2 = GetDouble("Введите значение X второй точки: ");
double y2 = GetDouble("Введите значение Y второй точки: ");
double z2 = GetDouble("Введите значение Z второй точки: ");

Distance(x1, y1, z1, x2, y2, z2);