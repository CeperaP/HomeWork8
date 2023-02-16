// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// (допустимый вариант)
// 6 16
// 9 6

int[,] RandomMatrix(int rows, int colums, int leftrange, int rightrange)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftrange, rightrange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Multip(int[,] A, int[,] B)
{
    int[,] multi = new int[A.GetLength(0), B.GetLength(1)];

    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < A.GetLength(1); k++)
            {
                sum = sum + (A[i, k] * B[k, j]);
            }

            multi[i, j] = sum;
        }
    }

    return multi;
}

const int ROWS = 4;
const int COLUMS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] arrayA = RandomMatrix( ROWS,COLUMS,LEFT_RANGE,RIGHT_RANGE);
PrintMatrix(arrayA);
System.Console.WriteLine();
int[,] arrayB = RandomMatrix( ROWS,COLUMS,LEFT_RANGE,RIGHT_RANGE);
PrintMatrix(arrayB);
System.Console.WriteLine();

int[,] ArrayAB=Multip(arrayA,arrayB);
PrintMatrix(ArrayAB);

