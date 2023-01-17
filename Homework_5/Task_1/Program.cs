// Задача 34: Напишите программу реализующую методы формирования массива,
//  заполненного случайными положительными трёхзначными числами, 
//  и подсчета количества чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();


Write("Input size your array: ");
if(!int.TryParse(ReadLine(),out int sizeArray))
{
    WriteLine("Error. Inputed not integer number.");
    return;
}
int[] mainArray = getArray(sizeArray);
PrintArray(mainArray);
int evenNum = findCountNumber(mainArray);
WriteLine($"Count even numbers in array is {evenNum}.");

int[] getArray(int size)
{
    int[] elements = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < elements.Length; i++)
    {
        elements[i] = rnd.Next(100, 1000);
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
int findCountNumber(int[] collection)
{
    int count = 0;
    foreach(int dig in collection)
    {
        if (dig % 2 == 0) count ++;
    }
    return count;
}