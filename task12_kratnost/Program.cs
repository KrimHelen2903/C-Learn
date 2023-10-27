/*
Программа, которая принимает на вход два числа и выводит, является ли второе числократным первому.
Если второе число некратно первому, то программа выводит остаток от леоения. 


*/

System.Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int multiple = Convert.ToInt32(Console.ReadLine());

if (number % multiple == 0)
{
    System.Console.WriteLine("Число чётное");
}
else 
{
    System.Console.WriteLine(number % multiple);
}

