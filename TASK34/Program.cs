// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите колчество чисел в массиве: ");

int N = Convert.ToInt32(Console.ReadLine());

int count = 0; // Счетчик четных чисел
int[] arr = new int[N];

Random rand = new Random(); 
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(100, 1000);
 if(arr[i]% 2 == 0){
    count++;
 }
}
Console.WriteLine('[' + string.Join(", ", arr) + ']');

Console.WriteLine($"Количество четных чисел: {count}");