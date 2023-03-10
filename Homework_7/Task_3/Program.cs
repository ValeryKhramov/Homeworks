// Задача 52. Напишите программу реализующую методы, формирования двумерного массива 
// и массива средних арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();
Write("Enter count rows and columns by space: ");
int[] intParameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);


int[,] elements = GetMatrixArray(intParameters[0], intParameters[1]);
PrintMatrixArray(elements);
WriteLine();
WriteLine("Arithmetic mean of each column: ");
double[] arithmeticMean = FindArithmeticMean(elements);
PrintArray(arithmeticMean);





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

double[] FindArithmeticMean(int[,] matrix)
{
    int SumColumn =0;
    int columns = 0;
    double[] resultArray = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            SumColumn += matrix[i,j];
        }

        resultArray[columns] = (double)SumColumn / matrix.GetLength(0);
        columns++;
        SumColumn = 0;
    }
    return resultArray;

}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Write($"{array[i],5:f1} ");
    }
}
