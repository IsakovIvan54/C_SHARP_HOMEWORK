// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = 3;
int n = 4;

int[,] matrix = new int[m, n];

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

int SumInSring(int[,] matrix, int ind){
int numSUM = 0;
for (int i = 0; i < n; i++)
{   
    
        numSUM += matrix[ind,i];
    
}
return numSUM;
}

int FindIndMin(int[] SUMmatrix){
    int IndF = 0;
    int min = SUMmatrix[0];
    for (int i = 0; i < m; i++)
    {   
        if(SUMmatrix[i] <= min){
            min = SUMmatrix[i];
            IndF = i;
        }
    }
return IndF;
}

int[] SUMmatrix = new int[m];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);

for (int i = 0; i < m; i++)
{   
    SUMmatrix[i]= SumInSring(matrix, i);
}
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindIndMin(SUMmatrix)}");