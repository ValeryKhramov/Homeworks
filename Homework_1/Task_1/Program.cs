using static System.Console;
Clear();

WriteLine("Сейчас мы найдем максимальное и минимальное значение из двух цифр.");
WriteLine("Введите первое число: ");
int number_1 = int.Parse(ReadLine()!);

WriteLine("Введите второе число: ");
int number_2 = int.Parse(ReadLine());

if (number_1 > number_2)
{
    WriteLine($"Max = {number_1}");
    WriteLine($"Min = {number_2}");
}
else
{
    WriteLine($"Max = {number_2}");
    WriteLine($"Min = {number_1}");
}


