// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = 12;
int n = 12;

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

int[,] matrix = new int[m, n];


int MaxInSring(int[,] matrix, int ind){
int maxNum = matrix[ind,0];
for (int i = 0; i < n; i++)
{   
    if(matrix[ind,i] >= maxNum){
        maxNum = matrix[ind,i];
    }
}
return maxNum;
}




int MinInSring(int[,] matrix, int ind){
int minNum = matrix[ind,0];
for (int i = 0; i < n; i++)
{
    if(matrix[ind,i] <= minNum){
        minNum = matrix[ind,i];
    }
}
return minNum;
}

void SorMatrixRow(int[,] matrix){

int tmp;
int[] MaxNumStr = new int[m];
int[] MinNumStr = new int[m];

for (int j = 0; j < m; j++){

MaxNumStr[j] = MaxInSring(matrix,j);
MinNumStr[j] = MinInSring(matrix,j);

int[] Temp = new int[n];
    for (int i = 0; i < n; i++){

        Temp[i] = matrix[j,i];

        if (Temp[i] == MaxNumStr[j]){
            tmp = Temp[0];
            Temp[0] = Temp[i];
            Temp[i] = tmp;
        }

     }
    
        for (int i = 0; i < n; i++){

        if(Temp[i] == MinNumStr[j]){
            tmp = Temp[n-1];
            Temp[n-1] = Temp[i];
            Temp[i] = tmp;
        }
    }

    for (int i = n-2; i > 0; i--){

        for (int h = 0; h <= i; h++)
        {   
            if(Temp[h] <= Temp[h+1])
            {
                tmp = Temp[h];
                Temp[h] = Temp[h+1];
                Temp[h+1] = tmp;
            }
        }
    }

    
for (int p = 0; p < n; p++){
    matrix[j,p] = Temp[p];  
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

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
SorMatrixRow(matrix);
System.Console.WriteLine("Результат: ");
PrintMatrix(matrix);
