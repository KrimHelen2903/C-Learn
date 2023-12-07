/*
Программа, которая на вход принимает число (N) и выдает таблицу квадратов этого числа.
*/

System.Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;

for( i = 1; i > 0; i++)
{
    num = num * num;
}
System.Console.WriteLine(num);