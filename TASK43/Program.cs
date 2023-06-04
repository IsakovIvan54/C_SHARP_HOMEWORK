// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите b1: ");
double B1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k1: ");
double K1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double B2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double K2 = Convert.ToDouble(Console.ReadLine());



double x = (B2 - B1) / (K1 - K2);
double y = K1 * x + B1;


Console.Write($"Точка пересечения двух прямых: ({x}; {y}) "); 