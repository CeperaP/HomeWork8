// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void Change(int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                   int index = j + 1;
                 
                  int temp = 0;
            while (index  < array.GetLength(1))
            {              
                if (array[i, j] < array[i, index])
                {      
                    temp = array[i, index];
                    array[i, index] = array[i, j];
                    array[i, j] = temp;                   
                }  
                index++;      // написал эту строку,заработало, но не доходит почему, там for крутят циклы же?))       
            }
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

Change(array);
PrintMatrix(array);