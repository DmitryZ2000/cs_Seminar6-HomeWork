// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

double FindY(double k1, double b1, double k2, double b2)
{
    return k1 * (b2 - b1) / (k1 - k2) + b1;
}

Console.Write("Введите k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * (b2 - b1) / (k1 - k2) + b1;
double x = FindX(k1, b1, k2, b2);
double y = FindY(k1, b1, k2, b2);
if (k1 == k2) Console.WriteLine("Прямые никогда не пересекутся");
else Console.WriteLine($"Точкой пересечения 2-х прямых является ({x};{y})");