// Задача 38: Напишите программу реализующую методы формирования массива,
// заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.

// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
Clear();

Write("Input size your array: ");
if(!int.TryParse(ReadLine(),out int sizeArray))
{
    WriteLine("Error. Inputed not integer number.");
    return;
}

double[] res = getArray(sizeArray);
PrintArray(res);
double result = differenceMaxMin(res);
WriteLine($"Diffence between maximum value and minimal value is {result:f1}.");



double[] getArray(int size)
{
    double[] elements = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < elements.Length; i++)
    {
        elements[i] =rnd.Next(-10,10) + rnd.NextDouble();
    }
    return elements;
}

void PrintArray(double[] arr)
{
    Write($"[ ");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]:f1} ");
    }
    WriteLine($"{arr[arr.Length - 1]:f1} ]");
}

double differenceMaxMin(double[] collection)
{
    double sum = 0;
    sum = collection.Max() - collection.Min();
    return sum;
}
