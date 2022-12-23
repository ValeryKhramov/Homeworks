//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();

 WriteLine("Input coordinates the first point (x,y,z): ");
 if(!int.TryParse(ReadLine(), out int x) || !int.TryParse(ReadLine(), out int y) || !int.TryParse(ReadLine(), out int z))
 {
    WriteLine("Error. Input integer, not string");
    return;
 }

  WriteLine("Input coordinates the second point (x,y,z): ");
 if(!int.TryParse(ReadLine(), out int x1) || !int.TryParse(ReadLine(), out int y1) || !int.TryParse(ReadLine(), out int z1))
 {
    WriteLine("Error. Input integer, not string");
    return;
 }

 double Distance = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2) + Math.Pow((z1 - z), 2));

 WriteLine($"Distance between two points equal to {Distance}");

