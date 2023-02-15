// Задача 56: Задайте двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


void MinSum(int[,] array) 
{
    int[] SSumma = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }

        SSumma[i] = sum;
    }
    
    
    
    int minSum = SSumma[0];
    for (int i = 0; i < SSumma.Length; i++)
    {
        if (SSumma[i] < minSum) 
        {
            minSum = SSumma[i];
        }
    }

    Console.Write("Номер строк(и) с наименьшей суммой элементов: ");

    for (int i = 0; i < SSumma.Length; i++)
    {
        if (SSumma[i] == minSum) 
        {
            Console.Write($"[{i+1}] ");
        }
    }
}

const int ROWS = 3;
const int COLUMS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] array = RandomMatrix(ROWS, COLUMS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);
System.Console.WriteLine();

MinSum(array);

