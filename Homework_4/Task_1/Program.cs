// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

using static System.Console;
Clear();

Write("Input first integer number: ");
if(!int.TryParse(ReadLine(), out int numberOne))
{
    WriteLine("Error.Input integer number.Not string.");
    return;
}
Write("Input second integer number: ");
if(!int.TryParse(ReadLine(), out int numberTwo))
{
    WriteLine("Error.Input integer number.Not string.");
    return;
}

int res = exponentiation(numberOne, numberTwo);
WriteLine($"{numberOne} in degree {numberTwo} = {res}");

int exponentiation(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result *= num1;
    }

    return result;
}