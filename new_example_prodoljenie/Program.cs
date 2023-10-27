/*
Программа, которая принимает на вход три числа и выдает максимальное из трёх чисел. 
*/

System.Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if (n2 > max)
    max = n2;
if (n3 > max)
    max = n3;
System.Console.WriteLine("Максимальное число " + max);

