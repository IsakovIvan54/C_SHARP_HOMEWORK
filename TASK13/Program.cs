// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");

int InNum = Convert.ToInt32(Console.ReadLine());
int Num = InNum; 

if(Num < 100 && Num > -100){
    Console.Write("Третьей цифры нет");
}

else {
    // добавление отрицательных значений
    if (Num < -99){
        Num = -Num;
    }
    while(Num > 1000){
        Num = (Num - Num % 10) / 10;
    }

    int OutNum = Num % 10;
    Console.Write($"{OutNum}");
}


