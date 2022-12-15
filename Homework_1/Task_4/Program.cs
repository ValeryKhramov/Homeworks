using static System.Console;
Clear();

WriteLine("Четные числа от 1 до N.");
WriteLine("Введите положительное число: ");
int number = int.Parse(ReadLine());
int count = 1;

if (number >= 1)
{
    while (count < number + 1)
    {
        if (count % 2 == 0)
        {
            WriteLine(count);
        }
        count += 1; 
    }
}
else
{
    WriteLine("Ошибка ввода.");
}