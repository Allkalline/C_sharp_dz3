﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.Write("Введите X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double d = ((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
//d = Math.Sqrt(d);

Console.WriteLine(Math.Sqrt(d));