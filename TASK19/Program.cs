// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите пятизначное число: ");

int InNum = Convert.ToInt32(Console.ReadLine());

int firstNum = InNum % 10;
int secondNum = (InNum % 100 - InNum % 10) / 10;
int fourNum = (InNum % 10000 - InNum % 1000) / 1000;
int fifthNum = (InNum % 100000 - InNum % 10000) / 10000;




if(InNum > 9999 && InNum < 100000){
     if (firstNum == fifthNum && secondNum == fourNum) {
        Console.Write("Введенное число является палиндромом");
    }
    else {
         Console.Write("Введенное число не является палиндромом");
    }
    
}
else {
    Console.Write("Число не является пятизначным");
}