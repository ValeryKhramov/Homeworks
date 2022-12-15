using static System.Console;
Clear();

WriteLine("Явлется ли число четным?");
WriteLine("Введите число: ");
int number = int.Parse(ReadLine());

if (number % 2 == 0)
{
    WriteLine($"Число {number} - четное.");
}
else
{
    WriteLine($"Число {number} - нечетное.");
}