/*
Программа, которая принимает на вход два числа и проверяет является ли одно число квадратом другого.
Например:
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8, 9 -> нет
*/

System.Console.WriteLine("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());



if (num2 == num * num)
{
    System.Console.WriteLine($"Число {num2} квадрат числа {num}");
}
if (num == num2 * num2)
{
    System.Console.WriteLine($"Число {num}  квадрат числа {num2}");
}
else if (num2>=num2)
{
    System.Console.WriteLine("Числа не являются квадратом");
}



