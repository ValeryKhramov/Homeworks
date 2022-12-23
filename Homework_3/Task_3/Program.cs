//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

using static System.Console;
Clear();

Write("Input any integer: ");
if(!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Error. Input integer, not string.");
    return;
}
int count = 1;

if (N > 0)
{
    while (count < N + 1)
    {
        Write($"{Math.Pow(count, 3)} ");
        count++;
    }
}
else
{
    count = -count;
  while (count > N - 1)
    {
        Write($"{Math.Pow(count, 3)} ");
        count--;
    }  
}