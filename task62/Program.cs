// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



void Spiral(int[,] matrix, int rows, int columns)
{
    int n = rows, m = columns, c = 0, i = 0, j = 0, k = 0;

    while (k < rows * columns)
    {
        for (j = c; j < m; j++)
        {
            if (k == rows * columns) break;
            matrix[i, j] = k;
            k++;
        }
        j--;
        
        for (i = c + 1; i < n; i++)
        {
            if (k == rows * columns) break;
            matrix[i, j] = k;
            k++;
        }
        i--;
        
        for (j = m - 2; j >= c; j--)
        {
            if (k == rows * columns) break;
            matrix[i, j] = k;
            k++;
        }
        j++;
        
        for (i = n - 2; i >= c + 1; i--)
        {
            if (k == rows * columns) break;
            matrix[i, j] = k;
            k++;
        }
        
        c++;
        n--;
        m--;
        i = c;
    }
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             if (matrix[i, j] < 10) Console.Write("0" + matrix[i, j] + " ");
            else Console.Write(matrix[i, j] + " ");
            
        }
        Console.WriteLine();
    }
}

int[,]array=new int[4,4];
Spiral(array,4,4);
Print(array);

