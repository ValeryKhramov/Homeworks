using static System.Console;
Clear();

WriteLine("Сейчас мы найдем максимальное значение из трех чисел.");
WriteLine("Введите первое число: ");
int number_1 = int.Parse(ReadLine()!);

WriteLine("Введите второе число: ");
int number_2 = int.Parse(ReadLine()!);

WriteLine("Введите третье число: ");
int number_3 = int.Parse(ReadLine()!);

int max = number_1;

if (number_2 > max) max = number_2;
if (number_3 > max) max = number_3;

WriteLine($"Максимальное значение равно {max}");
