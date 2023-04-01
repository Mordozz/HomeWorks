/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты X точки А = ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки А = ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки А = ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты X точки B = ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки B = ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки B = ");
int z2 = int.Parse(Console.ReadLine());


Console.Write($"Расстояние между точками = {getRadiant(x1, y1, z1, x2, y2, z2)}");

double getRadiant(int x1, int y1, int z1, int x2, int y2, int z2){
    Console.WriteLine($"A = {x1}, {y1}, {z1};\r\nB = {x2}, {y2}, {z2}");
    double num = Math.Sqrt((Math.Pow((x2-x1),2)) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return num;
}