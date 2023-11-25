/*
Программа, которая на вход принимает число и выдает количество цифр в этом числе.
*/

System.Console.WriteLine("Enter number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

/*int count = 0;
for(int i = number; i > 0; i %= 10)
{
    count = count + 1;
}*/


int Result(int number)
{
    int count = 0;
    for (int i = number; i > 0; i %= 10)
    {
        count = count + 1;
    }
    return count;
}
int userCount = Result(userNum);
System.Console.WriteLine(userCount);

