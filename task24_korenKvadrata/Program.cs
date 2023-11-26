/*
Программа, которая принимает на вход число (N) и выдает сумму чисел от 1 до N.
*/

/*System.Console.WriteLine("Enter number: ");

int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= num; i++)
{
    sum = sum + i;
} 
System.Console.WriteLine(sum);*/


System.Console.WriteLine("Enter number: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summer(int a)
{
    int summ = 0;

    for (int i = 1; i <= a; i++)
    {
        summ = summ + i;
    }
    return summ;
}
int userResult = Summer(userA);
System.Console.WriteLine(userResult);