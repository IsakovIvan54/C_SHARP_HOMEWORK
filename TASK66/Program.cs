// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumIn(int n, int m)
{
if (n < m)
{
return 0;
}
return n + SumIn(n - 1, m);
}


System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма элементов в промежутке от {m} до {n}: {SumIn(n, m)}");
