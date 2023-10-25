/*
2. Найти большее из двух чисел. Например:
a = 5; b = 7 -> Первое число 5 именьше чем второе число 7
a = 2; b = 2 -> Введенные числа равны
a = -3; b = -9 -> Первое число -3 больше чем второе число -9
*/

System.Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());


if (firstNum < secondNum)
{
    System.Console.WriteLine($"Перыое число {firstNum} меньше чем второе {secondNum}");
}
else if (firstNum > secondNum)
{
    System.Console.WriteLine($"Первое число {firstNum} больше чем {secondNum}");
}
else if (firstNum == secondNum)
{
    System.Console.WriteLine($"Первое число {firstNum} равно второму {secondNum}");
}
