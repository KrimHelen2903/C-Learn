/*
Программа, которая на вход принимает число и проверяет, кратно ли оно одновремено 7 и 23.
14 ->нет
46 ->нет
161 ->да
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)

    System.Console.WriteLine("Да");

else
{
    System.Console.WriteLine("Нет");
}
