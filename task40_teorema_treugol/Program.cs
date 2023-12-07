/*
Программа, которая на вход принимает 3 числа и проверяет, может ли существовать треугольник 
с сторонами такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.
*/

//System.Console.WriteLine("Введите число A: ");
//int userA = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Введите число B: ");
//int userB = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Введите число C: ");
//int userC = Convert.ToInt32(Console.ReadLine());
//
//
//bool Triagle(int a, int b, int c)
//{
//    bool result = false;
//    if (a + b > c && a + c > b && b + c > a)
//    {
//        result = true;
//    }
//    return result;
//}
//
//System.Console.WriteLine(Triagle(userA, userB, userC));


Console.WriteLine("Введите длинны трёх сторон треугольника");
Console.Write("Сторона A: ");
double userA = double.Parse(Console.ReadLine());

Console.Write("Сторона B: ");
double userB = double.Parse(Console.ReadLine());

Console.Write("Сторона C: ");
double userC = double.Parse(Console.ReadLine());


bool isTriangle = IsTriangle(userA, userB, userC);
{
    if(isTriangle)
    {
        Console.WriteLine("Треугольник с такими сторонами существует.");
    }
    else
    {
        Console.WriteLine("Треугольник с такими сторонами не существует.");
    }
}
bool IsTriangle(double a,double b, double c)
{
    return a + b > c && a + c > b && b + c > a;
}
