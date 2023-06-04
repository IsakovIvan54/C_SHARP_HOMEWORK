// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                 matrix[i, j] = rnd.Next(0, 100); // 
            }
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        System.Console.Write($"{matrix[i, j]} " + "\t");
        }
    System.Console.WriteLine();
    }
}

System.Console.Write("Введите номер строки элемента массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер  столбца элемента массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[3, 4];

System.Console.WriteLine("Массив:");
FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);

if (m <= 3 && n <=4){
    System.Console.WriteLine($"Значения элемента массива в строке {m} и столбце {n} это {matrix[m-1,n-1]}");
}
else {
   System.Console.WriteLine("Такого числа в массиве нет"); 
}
