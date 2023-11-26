/*
Внутри класса Answer напишите метод DistanBetweenPoints,
который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
и возвращает растояние между ними в 3D пространстве.

A (3,6,8); B(2,1,-7) -> 15.84
A (7,-5,0); B(1,-1,9) -> 11.53
*/ 


System.Console.WriteLine("Enter number: ");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter number: ");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter number: ");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter number: ");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter number: ");
int y2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter number: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2);
double g = Math.Round(Math.Pow);