// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();
Write("Enter count rows and column in first matrix by space: ");
int[] parametersOne = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

Write("Enter count rows and column in second matrix by space: ");
int[] parametersTwo = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

int[,] elements = CreateMatrix(parametersOne[0],parametersOne[1]);
PrintMatrix(elements);
WriteLine();

int[,] collecion = CreateMatrix(parametersTwo[0],parametersTwo[1]);
PrintMatrix(collecion);
WriteLine();

if(elements.GetLength(1) == collecion.GetLength(0))
{
int[,] productMatrix = MatrixMultiplication(elements, collecion);
PrintMatrix(productMatrix);
}
else WriteLine("The product of the given matrices is impossible.");


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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    // if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) throw new Exception("The product of the given matrices is impossible.);
    // {
    //     WriteLine("The product of the given matrices is impossible.");
        
    // }
    int[,] resultMatrix = new int[firstMatrix.GetLength(0),secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resultMatrix[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
            }
        }
    }

    return resultMatrix;
}