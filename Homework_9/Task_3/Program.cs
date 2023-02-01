// Задача 68: Напишите программу реализующую метод вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

Write("Enter integer positive number M and N by space: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

WriteLine(functionAckerman(parameters[0], parameters[1]));

int functionAckerman(int oneNum, int twoNum)
{
    if(oneNum == 0) return twoNum + 1;
    else if(oneNum > 0 && twoNum == 0) return functionAckerman(oneNum -1, 1);
    else if(oneNum > 0 && twoNum > 0) return functionAckerman(oneNum - 1, functionAckerman(oneNum, twoNum - 1));
    else return twoNum +1;
}