// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();
Write("Enter count rows and column in nartix by space: ");
int[] parameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

int[,] elements = CreateMatrix(parameters[0],parameters[1]);
PrintMatrix(elements);
int[] minimalSumRows = FindMinSumRowsMatrix(elements);
WriteLine($"The smallest sum of elements in {minimalSumRows[1]} row = {minimalSumRows[0]}");


int[,] CreateMatrix(int rows, int columns)
{
    int[,] resultMatrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = rnd.Next(10);
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

int[] FindMinSumRowsMatrix(int[,] inMatrix)
{
    int[] result = new int[2];
    int sum = 0;
    result[0] = int.MaxValue;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            sum += inMatrix[i,j];
        }

        if (sum < result[0])
        {
            result[0] = sum;
            result[1] = i;
        }
        sum = 0;

    }

    return result;
}