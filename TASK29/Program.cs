// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");
    int InNum = Convert.ToInt32(Console.ReadLine());
    array[i] = InNum;

}
Console.WriteLine('[' + string.Join(", ", array) + ']');



