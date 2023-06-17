// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"



void RoadFromN(int number)
{

System.Console.Write($"{number} ");
if (number == 1)
{
return;
}

RoadFromN(number-1);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadFromN(number);

