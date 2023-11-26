/*
Внутри класса Answer напишите метод IsPalidrom, который на вход принимает пятизначное число (N),
и проверяет, является ли оно палидромом.
Метод должен проверять является ли число пятизначным, в противном случае - вывести число не пятизначное и Fals в след. строке.
Для остальных чисел вернуть True
*/

Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n4 = n /10 % 10;
int n5 = n % 10;

if( n >= 10000 && n <= 99999)
{
    if(n1 == n5 && n2 == n4)
    {
        System.Console.WriteLine("True");
    }
    else
    System.Console.WriteLine("Fals");
    
}
else
{
    System.Console.WriteLine("Не пятизначное число");
}
