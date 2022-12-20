using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine());

if (number >= 100)
{
    while (number >= 999)
    {
        number = number / 10;
    }
    WriteLine(number % 10);
}
else
{
    WriteLine("Третьей цифры нет.");
}
