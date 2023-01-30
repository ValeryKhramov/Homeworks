// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();
Write("Enter count rows and column in nartix by space: ");
int[] parameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

int[,] elements = CreateMatrix(parameters[0],parameters[1]);
PrintMatrix(elements);
WriteLine();
SortRowsMarix(elements);
PrintMatrix(elements);


int[,] CreateMatrix(int rows, int columns)
{
    int[,] resultMatrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = rnd.Next(-10,10);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j], 5}");
        }
        WriteLine();
    }
}

void SortRowsMarix(int[,] inMatrix)
{   
    int temp = int.MinValue;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix.GetLength(1); k++)
            {
                if(inMatrix[i,j] <= inMatrix[i,k]) continue;
                temp = inMatrix[i,j];
                inMatrix[i,j] = inMatrix[i,k];
                inMatrix[i,k] = temp;
            }
        }
    }
}
