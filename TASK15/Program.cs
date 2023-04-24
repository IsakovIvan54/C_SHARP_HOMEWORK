
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int inNumberWeek = Convert.ToInt32(Console.ReadLine());

if (inNumberWeek == 1 || inNumberWeek == 2 || inNumberWeek == 3 || inNumberWeek == 4 || inNumberWeek == 5){
    Console.Write("Будний");
}
else if (inNumberWeek == 6 || inNumberWeek == 7){
    Console.Write("Выходной");
}
else {
    Console.Write("Дня недели с таким номером не существует");
}
