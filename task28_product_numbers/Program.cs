/*
Программа которая на вход принимает число (N) и выдает произведение чисел от 1 до N.
*/ 

System.Console.WriteLine("Enter number: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Prodact(int a)
{
    int result = 1;

    for (int i = 1; i <= a; i++)
    {
        result = result * i;
    }
    return result;
}
int userResult = Prodact(userA);
System.Console.WriteLine(userResult);

