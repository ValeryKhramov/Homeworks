using static System.Console;
Clear();

WriteLine("Введите цифру дня недели: ");
int number = int.Parse(ReadLine());
WriteLine(number >= 1 && number <= 7? (number == 6 || number == 7? "Да": "Нет"):"Ошибка ввода.");