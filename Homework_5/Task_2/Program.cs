// Задача 36: Напишите программу реализующую методы формирования массива,
// заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

Write("Input size your array: ");
if(!int.TryParse(ReadLine(),out int sizeArray))
{
    WriteLine("Error. Inputed not integer number.");
    return;
}

int[] resultArray = getArray(sizeArray);
PrintArray(resultArray);
int resultSum = sumNumOddPosition(resultArray);
WriteLine($"Sum number in odd position in array is {resultSum}.");




int[] getArray(int size)
{
    int[] elements = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < elements.Length; i++)
    {
        elements[i] = rnd.Next(-99, 100);
    }
    return elements;
}

void PrintArray(int[] arr)
{
    Write($"[ ");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]}, ");
    }
    WriteLine($"{arr[arr.Length - 1]} ]");
}

int sumNumOddPosition(int[] collection)
{
    int sum = 0;
    for(int i = 0; i < collection.Length; i++)
    {
        if (i % 2 != 0) sum += collection[i];
    }
    return sum;
}
