// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");

int InNum = Convert.ToInt32(Console.ReadLine());

int N = LenthNum(InNum);
int[] Numbers = new int[N];
int Result = 0;


// Функция для расчета количества цифр в числе
int LenthNum(int ph){
    int count = 0;
        while(ph > 0) {
            
        ph = (ph - ph % 10) / 10;
        count++;
}
    return count;
}

// Заполнение массива цифр числа
for (int i = 0; i <= N-1; i++){

    Numbers[i] =((InNum % (10 * Convert.ToInt32(Math.Pow(10, i))))  - (InNum % Convert.ToInt32(Math.Pow(10, i)))) / Convert.ToInt32(Math.Pow(10, i));
    Result += Numbers[i];
}


Console.WriteLine($"Сумма цифр в числе: {Result}");