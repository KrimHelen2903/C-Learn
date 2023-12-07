/*
Программа, которая на вход принимает число (N) и выдает кубы чисел от 1 до N

N = 3
1  8  27
N = 5
1  8  27  64  125
*/

Console.WriteLine("Enter number: ");

int number = Convert.ToInt32(Console.ReadLine());

if ( number >= 1) {

    for (int i = 1; i < number; i++)
    {
        if (i > 1)  Console.Write(", "); 
        Console.Write(i*i*i); 
    }

}