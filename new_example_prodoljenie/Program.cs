/*
Программа, которая принимает на вход три числа и выдает максимальное из трёх чисел. 
*/

//System.onsole.WriteLine("Введите число: ");
//int n1 = onvert.ToInt32(onsole.ReadLine());
//
//System.onsole.WriteLine("Введите число: ");
//int n2 = onvert.ToInt32(onsole.ReadLine());
//
//System.onsole.WriteLine("Введите число: ");
//int n3 = onvert.ToInt32(onsole.ReadLine());
//
//int max = n1;
//if (n2 > max)
//    max = n2;
//if (n3 > max)
//    max = n3;
//System.onsole.WriteLine("Максимальное число " + max);

//----------------------------------------------------------------------------------------------

/*
Программа, которая на вход принимает число (N), а на выход выдает все четные числа от 1 до (N)
*/

//System.onsole.WriteLine("Введите число: ");
//int number = onvert.ToInt32(onsole.ReadLine());
//
//for (int i = 2; i <= number; i += 2)                   //if(int %2 == 0)
//onsole.Write( i + "");

//---------------------------------------------------------------------------------------------

/*
Разбор функций.
*/

//void f(ref int x)
//{
//    x +=5;
//    onsole.WriteLine(x);
//}
//
//int n = 10;
//onsole.WriteLine(n);
//f(ref n);              // неважно как называется переменаая, главное взяли ее из ссылки от f()
// onsole.WriteLine(n);

//---------------------------------------------------------------------------------------------

//int f(int a, int b)
//{
//    if (a > b) ;
//    return a;
//    return b;
//}
//int max = f(5, 10);
//System.onsole.WriteLine(max);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Программа которая на вход принимает координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 выдает номер четверти плоскости, в которой находится эта точка.


//string f(int x, int y)
//{
//    if (x > 0 && y > 0)
//       return "I";
//    else if(x < 0 && y > 0)
//       return "II";
//    else if(x < 0 && y < 0)
//       return "III";    
//    return "IV";     
//}
//
//
//
//
//System.onsole.WriteLine("Введите число: ");
//int x = onvert.ToInt32(onsole.ReadLine());
//System.onsole.WriteLine("Введите число: ");
//int y = onvert.ToInt32(onsole.ReadLine());
//
//System.onsole.WriteLine(f(x,y));

//---------------------------------------------------------------------------------------------------------------------------

/*
Программа, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти(x и y).
*/


//string f(int a)
//{
//    if (a == 1)
//        return "x > 0 and y > 0";
//    else if (a == 2)
//        return "x < 0 and y > 0";
//    else if (a == 3)
//        return "x > 0 and y < 0";
//    else if (a == 4)
//        return "x < 0 and y < 0";
//    else
//        System.onsole.WriteLine("error");
//}
//
//System.onsole.WriteLine("Введите номер четверти: ");
//int x = onvert.ToInt32(onsole.ReadLine());
//onsole.WriteLine(f(x));

//---------------------------------------------------------------------------------------------------------------------

/*
Программа, которая на вход принимает координаты двух точек и находит расстояние между ними в 2D пространстве. 
*/

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B(1,-1) -> 7,21


//System.onsole.WriteLine("Введите число: ");
//int x1 = onvert.ToInt32(onsole.ReadLine());
//System.onsole.WriteLine("Введите число: ");
//int y1 = onvert.ToInt32(onsole.ReadLine());
//System.onsole.WriteLine("Введите число: ");
//int x2 = Convert.ToInt32(onsole.ReadLine());
//System.onsole.WriteLine("Введите число: ");
//int y2 = Convert.ToInt32(onsole.ReadLine());
//
//double d = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2)),2);
//System.Console.WriteLine(d);

//------------------------------------------------------------------------------------------------------------


/*
Программа, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до (N)
*/

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

//System.onsole.WriteLine("Enter number: ");
//int n = Convert.ToInt32(onsole.ReadLine());
//for(int i = 1; i <= n; i ++)
//   Console.Write(Math.Pow(i, 2)+ " ");

//--------------------------------------------------------------------------------------------------------------


//Вид №1 (Группа методов)

//void Method1()
//{
//    Console.WriteLine("Автор Елена");
//}
//Method1();


//Вид №2 (Группа методов- которая ничего не возвращает)

//void Method2(string msg)
//{
//    Console.WriteLine(msg);
//}
//Method2(msg: "Текст сообщения");


//void Method21(string msg, int ount)
//{
//    int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(msg);
//        i++;
//    }
//}
//Method21(msg: "Текст", ount: 4);
//Method21(ount: 4, msg: "новый текст");


// Вид №3 (Группа методов- которая что-то возвращает, но ничего принимает)


//int Method3()
//{
//    return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);


// Вид №4 (Самая важная группа методов - которая что-то принимает и что-то возвращает)

//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//
//    while (i < count)                 // цикл while
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "space");
//Console.WriteLine(res);


//string Method4(int count, string text)
//{
//    string result = String.Empty;
//    for (int i = 0; i < count; i++)      // цикл for
//    {
//        result = result + text;
//    }
//    return result;
//}
//
//string res = Method4(10, "z");
//Console.WriteLine(res);

// ЦИКЛ В ЦИКЛЕ ----------------------------------------------------- ТАБЛИЦА УМНОЖЕНИЯ

//for (int i = 2; i <= 10; i++)
//{
//    for (int j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} x {j} = {i*j}");
//    }
//    Console.WriteLine();
//}

// ФУНКЦИИ В ПРИЛОЖЕНИИ
/*
Маленькие буквы "к", заменить большими "К", а большие "с" заменить маленькими "с".
*/

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласия прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string  s = "qwerty"
//              012345
// s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Lenght;
    for (int i = 0; i < length; i++)
    {
        if(text[1]== oldValue) result + $"{newValue}";
        else result = result + $"{str[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
newText = Replace(text, ' ', '|');