// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int InFirstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int InSecondNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число число: ");
int InThirdNum = Convert.ToInt32(Console.ReadLine());



if (InFirstNum > InSecondNum && InFirstNum > InThirdNum){
    Console.Write($"Число {InFirstNum} масимальное");
}

else if (InSecondNum > InFirstNum && InSecondNum > InThirdNum){
    Console.Write($"Число {InSecondNum} масимальное");
}

else if (InThirdNum > InFirstNum && InThirdNum > InSecondNum){
    Console.Write($"Число {InThirdNum} масимальное");
}

else {
    Console.Write("Введенные числа равны друг другу");
}