/*
Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого чесла.
*/


System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number >= 100 ) {
    Console.WriteLine("Вторая цифра числа "+number+" = "+(number%100-number%10)/10);
} else {
    Console.WriteLine("Число не трехзначное");
}
