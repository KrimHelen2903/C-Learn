/*
Не используя рекурсию, выведите первые N числа 
Фабоначчи. Первые два числа Фабоначи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

/*
int UserInOut(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNum = UserInOut("Введите число: ");

int FabonNum(int a)
{
    string[] result = "";
    if (a == 0) result = "0";
    if (a == 1) result = "0 1";
    if (a > 1)
    {
        for (int i = 0; i <= a; i++)
        {
            result = result + i;
        }
    }
    return result;

}

System.Console.WriteLine(FabonNum(userNum));*/

/*
int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Fabonachi(int number)
{
    int size = number;
    if (number < 2)
        size = 2;


    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    Console.Write("Число N = " + arrayOne.Length + ": ");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(" " + arrayOne[i]);
    }
}

int number = Prompt("Введите десятичное число: ");
PrintArray(Fabonachi(number));
*/


Console.Write("Введите количество чисел Фабоначчи: ");
int N = int.Parse(Console.ReadLine());
if (N < 1)
{
    Console.WriteLine("Пожалуйства, введите положительное число: ");
    return;
}

int first = 0;
int second = 1;

Console.Write(" Первые " + N + " Чисел Фабоначи: ");

if (N >= 1)
{
    Console.Write(first);
}

if (N >= 2)
{
    Console.Write(", " + second);
}

for (int i = 3; i <= N; i++)
{
    int next = first + second;
    Console.Write(", " + next);
    first = second;
    second = next;
}
System.Console.WriteLine();