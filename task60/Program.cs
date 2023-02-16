// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив,
//   добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Array = new int[2, 2, 2];
int count = 10;
for (int h = 0; h < 8; h++)
{
    count++;
}

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int k = 0; k < Array.GetLength(2); k++)
        {

            Array[i, j, k] = count;
            count++;
            System.Console.Write($"{Array[i, j, k]} ({i},{j},{k})\t");
        }
        System.Console.WriteLine();
    }
    
}


