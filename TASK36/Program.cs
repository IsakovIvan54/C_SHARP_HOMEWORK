// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write("Введите колчество чисел в массиве: ");

int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int Sum = 0;

Random rand = new Random(); 
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-99, 100);
    if(i % 2 == 1){
        Sum += arr[i];
    }
}
Console.WriteLine('[' + string.Join(", ", arr) + ']');

Console.WriteLine($"Сумма нечетных чисел массива: {Sum}");
