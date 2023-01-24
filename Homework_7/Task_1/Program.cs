// Задача 47. Напишите программу реализующую метод,
// который возвращает массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 

using static System.Console;
Clear();
Write("Enter count rows and columns by space: ");
int[] intParameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);


double[,] elements = GetMatrixArray(intParameters[0], intParameters[1]);
PrintMatrixArray(elements);




double[,] GetMatrixArray(int rows, int columns)
{
    Random rnd = new Random();
    double[,] resultMatrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
          resultMatrix[i,j] = rnd.Next(-10, 10) + rnd.NextDouble();  
        }
    }
    return resultMatrix;
}

void PrintMatrixArray(double[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j],5:f1} ");
        }
        WriteLine();
    }
}