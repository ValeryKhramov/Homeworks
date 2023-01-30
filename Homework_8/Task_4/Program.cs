// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();
Write("Enter count rows, columns and block in matrix by space: ");
int[] parameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

int[,,] elements = CreateMatrix(parameters[0],parameters[1],parameters[2]);
PrintMatrix(elements);


int[,,] CreateMatrix(int rows, int columns, int block)
{
    int total = 0;
    int count = 0;
    int[,,] resultMatrix = new int[rows,columns,block];
    Random rnd = new Random();
     while(total < resultMatrix.GetLength(0) * resultMatrix.GetLength(1) * resultMatrix.GetLength(2) )
    {
        for (int i = 10; i < 100; i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(0) ; j++)
            {
                for (int k = 0; k < resultMatrix.GetLength(1); k++)
                {
                    for (int n = 0; n < resultMatrix.GetLength(2); n++)
                    {
                        if (resultMatrix[j,k,n] == 0) resultMatrix[j,k,n] = rnd.Next(10,100);
                        if (resultMatrix[j,k,n] == i) count += 1;
                        if (count >= 2) resultMatrix[j,k,n] = rnd.Next(10,100);
                    }
                }
            }
            count = 0;
        }
        total++;
   
    }
    
    return resultMatrix;
}

void PrintMatrix(int[,,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix.GetLength(2); k++)
            {
                Write($"{inMatrix[i,j,k],5}{(i,j,k)}");
            }
            WriteLine();
        }
        
    }
}
