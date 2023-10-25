/*
Метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

System.Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

System.Console.WriteLine("макимальное число: " + max);
return max;
