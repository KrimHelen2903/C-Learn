/*
Метод ChekIfEven, который на входит принимает число (N) и выводит является ли число четным (делится ли оно на два и без остатка)
*/

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
{
    int remain = num % 2;
    if (remain == 0)
    {
        System.Console.WriteLine($" Число {num} чётное");
    }
    else
    {
        System.Console.WriteLine($" Число {num} нечётное");
    }
}