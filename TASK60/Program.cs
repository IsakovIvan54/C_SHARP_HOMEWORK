// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = 2;
int n = 2;
int k = 2;

int[,,] matrix = new int[m, n, k];

void FillMatrixWhithRandomNumbers(int[,,] matrix)
{
    Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int r = 0; r < matrix.GetLength(2); r++)
                {
                    matrix[i, j, r] = rnd.Next(0, 100); 
                }
                 
            }
        }
}

void PrintMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int r = 0; r < matrix.GetLength(2); r++)
            {
            System.Console.Write($"{matrix[i, j, r]} {(i,j,r)} " + "\t");

            }
        }
    System.Console.WriteLine();
    }
}
FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);