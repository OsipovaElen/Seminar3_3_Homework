//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите по одной координаты x, y, z для точек трехмерного пространства А и B");
Console.WriteLine("Точка A координата x = ");
string ax = Console.ReadLine();
int numAx = int.Parse(ax);

Console.WriteLine("Точка A координата y = ");
string ay = Console.ReadLine();
int numAy = int.Parse(ay);

Console.WriteLine("Точка A координата z = ");
string az = Console.ReadLine();
int numAz = int.Parse(az);

Console.WriteLine("Точка B координата x = ");
string bx = Console.ReadLine();
int numBx = int.Parse(bx);

Console.WriteLine("Точка B координата y = ");
string by = Console.ReadLine();
int numBy = int.Parse(by);

Console.WriteLine("Точка B координата z = ");
string bz = Console.ReadLine();
int numBz = int.Parse(bz);

double result = Math.Sqrt(Math.Pow((numBx - numAx), 2) + Math.Pow((numBy - numAy), 2) + Math.Pow((numBz - numAz), 2) );

Console.Write($"Расстояние от точки A*{numAx},{numAy},{numAz}* до B*{numBx},{numBy},{numBz}* = {result}");