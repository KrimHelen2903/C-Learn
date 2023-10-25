/*
Программа, которая выводит случайное трехзначное число (N) и удаляет вторую цифру этого числа (N)
Например:
456 -> 46
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int integ = number / 100;
int doubl = number % 10;
string integ2 = Convert.ToString(integ);
string doubl2 = Convert.ToString(doubl);

System.Console.WriteLine(integ2 + doubl2);

