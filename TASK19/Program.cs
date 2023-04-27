// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите пятизначное число: ");

int InNum = Convert.ToInt32(Console.ReadLine());

int N = LenthNum(InNum);
int[] Numbers = new int[N];
int countMatch = 0;

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
}

// Счетчик совпадений цифр в числе
for (int j = 0; j < N/2; j++){
    if (Numbers[j] == Numbers[N-1-j]){
        countMatch++;
    }
}

if(countMatch == N/2){
    Console.Write("Введенное число является палиндромом");
}
else{
    Console.Write("Введенное число не является палиндромом");
}