/*
8. Программа, которая на вход принимает число (N), а на выход выводит все чётные числа от 1 до числа (N).
Метод PrintEvenNumbers.
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i++)
{
    //int remain = 1 % 2;
    //if (remain == 0)
        if (i % 2 == 0)
            System.Console.WriteLine(i + "\t");
}