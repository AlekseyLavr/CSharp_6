// See https://aka.ms/new-console-template for more information
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
void Point()
{
    Console.Write("Введите коэффициент угла наклона первой прямой: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэффициент угла наклона втророй прямой: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    if (k1 == k2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine($"Точка пересечения прямых: [{Math.Round(x, 2)}, {Math.Round(y, 2)}].");
    }
}
Point();