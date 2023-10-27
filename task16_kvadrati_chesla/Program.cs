/*
Программа, которая принимает на вход два числа и проверяет является ли одно число квадратом другого.
Например:
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8, 9 -> нет
*/

System.Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int square = Convert.ToInt32(Console.ReadLine());

if (square == number*number || number == square*square)
{
    System.Console.WriteLine("Числа являются квадратом");
}
else
{
    System.Console.WriteLine("Числа не являются квадратом");
}
