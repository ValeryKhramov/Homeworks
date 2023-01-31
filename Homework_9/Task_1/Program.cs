// Задача 64: Напишите программу, которая реализует рекурсивный метод вывода 
// всех натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();

Write("Enter integer number: ");

if(!int.TryParse(ReadLine()!, out int number))
{
    WriteLine("Error. Entered not integer number.");
    return;
}

WriteLine(PrintNumber(number));

string PrintNumber(int num)
{
    return (num == 1)? num.ToString(): $"{num}, {PrintNumber(num - 1)}";
}