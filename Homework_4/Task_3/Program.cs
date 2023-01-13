// Задача 29: Напишите программу, реализующую метод,
// который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
Clear();

int[] outcome = FullArray();
PrintArray(outcome);

int[] FullArray()
{
    int[] result = new int[8];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100);
        
    }
    return result;
}

void PrintArray(int[] array)
{
    Write($"[ ");
    for(int i = 0; i < array.Length; i++)
    {
        
        if (i == array.Length - 1)
        {
            Write($"{array[i]} ");
            break;
        }
        Write($"{array[i]}, ");
        
    }
    Write($"]");
}