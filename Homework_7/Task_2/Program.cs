// Задача 50. Напишите программу реализующую метод,принимающий позиции 
// элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;
Clear();

Write("Enter count rows and columns by space: ");
int[] intParameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

Write("Enter coordinates for element by \";\" ");
int[] numCoordinates = Array.ConvertAll((ReadLine()!.Split(";", StringSplitOptions.RemoveEmptyEntries)), int.Parse);


int[,] collection = GetMatrixArray(intParameters[0], intParameters[1]);
PrintMatrixArray(collection);
FindNumFromCoordinate(collection, numCoordinates);



int[,] GetMatrixArray(int rows, int columns)
{
    Random rnd = new Random();
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
          resultMatrix[i,j] = rnd.Next(100);  
        }
    }
    return resultMatrix;
}

void PrintMatrixArray(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j],5} ");
        }
        WriteLine();
    }
}

void FindNumFromCoordinate (int[,] matrix, int[] coordinateNum)
{
    if (matrix.GetLength(0) < coordinateNum[0] || matrix.GetLength(1) < coordinateNum[1])
    { 
        WriteLine("This element array not exist");
    }
    else WriteLine($"Element to your coordinates - {matrix[coordinateNum[0], coordinateNum[1]]}");
}