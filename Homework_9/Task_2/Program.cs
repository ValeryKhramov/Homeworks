// Задача 66: Напишите программу, которая реализует рекурсивный метод 
// нахождения суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

Write("Enter integer number M and N by space: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

WriteLine($"Sum range from {parameters[0]} to {parameters[1]} = {GetSumRange(parameters[0], parameters[1])}");

int GetSumRange(int startNum, int endNum)
{     
    if(startNum == endNum) return endNum;
    if(startNum < endNum) return GetSumRange(startNum + 1, endNum) + startNum;
    else return GetSumRange(startNum - 1, endNum) + startNum;
}
