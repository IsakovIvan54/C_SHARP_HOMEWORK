// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int m = 3;
int n = 4;

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

void PrintAverageMatrixCol(int[,] matrix){
double[] AverangeCol = new double[n];
int[] SumCol = new int[n];

for (int j = 0; j < n; j++){
    for (int i = 0; i < m; i++){
        SumCol[j] += matrix[i,j];
    }
    AverangeCol[j] = SumCol[j]/m;
    System.Console.WriteLine($"Среднее арифметическое столбца{j + 1}: {AverangeCol[j] }");
    }
}




int[,] matrix = new int[m, n];

System.Console.WriteLine("Массив:");
FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);




PrintAverageMatrixCol(matrix);