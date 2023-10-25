/*
Программа, которая выводит случайное число из отрезка [10, 3]
78 -> 8
12 -> 2
85 -> 8
*/

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);

int integer = number / 10;
int decimaL = number % 10;

if(integer>decimaL)
{
    System.Console.WriteLine("Наибольшее " + integer);
}
else
{
    System.Console.WriteLine("Наибольшее " + decimaL);
}
