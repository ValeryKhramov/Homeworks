// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

using static System.Console;
Clear();
Write("Enter some integer numbers separated by space: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);


int[] elementsInt = convertArray(parameters);
PrintArray(elementsInt);
int resultPositiveNum = findPositiveCount(elementsInt);
WriteLine($"Sum positive number in array = {resultPositiveNum}.");



int[] convertArray(string[] array)
{
    int[] resultArray = new int[array.Length];
    for(int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = Convert.ToInt32(array[i]);
    }
    return resultArray;
}

void PrintArray(int[] arr)
{
    Write($"[ ");
     for(int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]} ");
    }
    WriteLine($"{arr[arr.Length - 1]} ]");
}

int findPositiveCount(int[] collection)
{
    int count = 0;
    foreach(int dig in collection)
    {
        if (dig > 0) count += 1;
    }
    return count;
}
