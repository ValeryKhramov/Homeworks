// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


using static System.Console;
Clear();

Write("Input integer number: ");
if(!int.TryParse(ReadLine(), out int number))
{
    WriteLine("Error. Input integer number.");
    return;
}

int outcome = numSum(number);
WriteLine($"The sum of the digit = {outcome}");


int numSum(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}