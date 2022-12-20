using static System.Console;
Clear();

WriteLine("Введите трехзначное число: ");
int number = int.Parse(ReadLine());

WriteLine(number >= 100 && number <= 999? number % 100 / 10 : "Ошибка ввода.");