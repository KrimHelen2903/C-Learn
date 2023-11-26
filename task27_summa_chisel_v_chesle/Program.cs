/*
Программа которая на вход принимает число и выдает сумму чисел в цифре.
*/

System.Console.WriteLine("Enter number: ");
int userN = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int result = 0;
    for (int i = a; i > 0; i /= 10)
    {
        result = result % 10 + i;
    }
    return result;
}

int userResult = Num(userN);
System.Console.WriteLine($"{userN} -> {userResult}");
