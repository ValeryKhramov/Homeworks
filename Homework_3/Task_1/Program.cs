//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();

Write("Input five-digit number: ");
if(!int.TryParse(ReadLine(), out int number))
{
    WriteLine("Error. Input number, not string.");
    return;
}

if (number < 10000 || number > 99999)
{
    WriteLine("Error.Input five-digit nimber.");
    return;
}

if (number % 10 == number / 10000 && number % 100 / 10 == number / 1000 % 10 )
{
    WriteLine("Yes");
}
else
{
    WriteLine("No");
}