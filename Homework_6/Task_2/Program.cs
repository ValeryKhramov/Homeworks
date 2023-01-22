// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

Write("Enter value B and K for first direct by spase: ");
Direct firstDirect = GetDirectFromUser(ReadLine()!);
Write("Enter value B and K for second direct by spase: ");
Direct secondDirect = GetDirectFromUser(ReadLine()!);

double XPoint = (secondDirect.B - firstDirect.B)/(firstDirect.K - secondDirect.K);
double YPoint = (firstDirect.K * XPoint + firstDirect.B); 

WriteLine($"The intersection point of the lines has the following coordinates ({XPoint}:{YPoint})");


Direct GetDirectFromUser(string inStr)
{
    Direct result = new Direct();
    string[] parameters = inStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    result.B = Convert.ToDouble(parameters[0]);
    result.K = Convert.ToDouble(parameters[1]);
    return result;
}


struct Direct
{
    public double B;
    public double K;
}

