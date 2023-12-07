/*
Программа которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 
*/

int UserInOut(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

/*int ConvertToDouble(int number)
{
    int result = 0;
    int temp = 0; // или 1, в случае когда маленькое число
    for (int i = number; i > 0; i /= 2)
    {
        temp = i % 2;
        result = temp + result * 10;
    }
    return result;
}*/

string Conv(int number)
{
    string result = "";
    int temp = 0;
    for (int i = number; i > 0; i /= 2)
    {
        temp = i % 2;
        result = temp + result;
    }
    return result;
}


int userNumber = UserInOut("Введите число: ");
Console.WriteLine(Conv(userNumber));