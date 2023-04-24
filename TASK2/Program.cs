// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int InFirstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int InSecondNum = Convert.ToInt32(Console.ReadLine());


if (InFirstNum > InSecondNum){
    Console.Write($"Число {InFirstNum} больше чем {InSecondNum}");
}

else if (InFirstNum < InSecondNum){
    Console.Write($"Число {InSecondNum} больше чем {InFirstNum}");
}
else {
    Console.Write("Введенные числа равны друг другу");
}