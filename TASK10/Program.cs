// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");

int InNum = Convert.ToInt32(Console.ReadLine());

int OutNum = (InNum % 100 - InNum % 10) / 10;

if (InNum >99 && InNum <1000){
    Console.Write($"Вторая цифра числа {InNum} это {OutNum}");
}
else {
    Console.Write("Введенное число не трехзначное");
}
