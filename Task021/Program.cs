// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
Console.Clear();

Console.Write("Введите координаты x1: ");
Double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
Double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
Double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
Double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z1: ");
Double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
Double z2 = Convert.ToDouble(Console.ReadLine());

Double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"A({x1},{y1},{z1});B({x2},{y2},{z2})=> {distance:f2}");