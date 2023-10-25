/*
5. Программа которая на вход принимает одно число (N), 
а на выход показываетвсе целые числа в промежутке.
Например:
4-> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2-> "-2, -1, 0, 1, 2"
*/

System.Console.WriteLine("Введите число: ");

int numberA = Convert.ToInt32(Console.ReadLine());
int start = numberA * -1;

while (start <= numberA)
{
System.Console.WriteLine(start);
start = start + 1;
}