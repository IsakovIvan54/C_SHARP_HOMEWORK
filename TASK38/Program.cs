// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

Console.Write("Введите колчество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[N];
double maxNum = 0;
double minNum = 0;


for (int i = 0; i < arr.Length; i++)
{
    Console.Write("Введите число: ");
    double InNum = Convert.ToDouble(Console.ReadLine());
    arr[i] = InNum;
    maxNum = arr[0];
    minNum = arr[0];
    if(arr[i] >= maxNum){
        maxNum = arr[i];
    }
    else if(arr[i] <= minNum){
        minNum = arr[i];
    }

}

double difference = maxNum - minNum;

Console.WriteLine('[' + string.Join(", ", arr) + ']');
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {difference}");
