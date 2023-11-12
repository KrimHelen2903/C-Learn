/*
Программа, которая принимает на вход три числа и выдает максимальное из трёх чисел. 
*/

//System.Console.WriteLine("Введите число: ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//
//System.Console.WriteLine("Введите число: ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//
//System.Console.WriteLine("Введите число: ");
//int n3 = Convert.ToInt32(Console.ReadLine());
//
//int max = n1;
//if (n2 > max)
//    max = n2;
//if (n3 > max)
//    max = n3;
//System.Console.WriteLine("Максимальное число " + max);

//----------------------------------------------------------------------------------------------

/*
Программа, которая на вход принимает число (N), а на выход выдает все четные числа от 1 до (N)
*/

//System.Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//
//for (int i = 2; i <= number; i += 2)                   //if(int %2 == 0)
//Console.Write( i + "");

//---------------------------------------------------------------------------------------------

/*
Разбор функций.
*/

//void f(ref int x)
//{
//    x +=5;
//    Console.WriteLine(x);
//}
//
//int n = 10;
//Console.WriteLine(n);
//f(ref n);              // неважно как называется переменаая, главное взяли ее из ссылки от f()
// Console.WriteLine(n);

//---------------------------------------------------------------------------------------------

//int f(int a, int b)
//{
//    if (a > b) ;
//    return a;
//    return b;
//}
//int max = f(5, 10);
//System.Console.WriteLine(max);

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
//System.Console.WriteLine("Введите число: ");
//int x = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Введите число: ");
//int y = Convert.ToInt32(Console.ReadLine());
//
//System.Console.WriteLine(f(x,y));

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
//        System.Console.WriteLine("error");
//}
//
//System.Console.WriteLine("Введите номер четверти: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(f(x));

//---------------------------------------------------------------------------------------------------------------------

/*
Программа, которая на вход принимает координаты двух точек и находит расстояние между ними в 2D пространстве. 
*/

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B(1,-1) -> 7,21


//System.Console.WriteLine("Введите число: ");
//int x1 = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Введите число: ");
//int y1 = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Введите число: ");
//int x2 = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Введите число: ");
//int y2 = Convert.ToInt32(Console.ReadLine());
//
//double d = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2)),2);
//System.Console.WriteLine(d);
 
//------------------------------------------------------------------------------------------------------------


/*
Программа, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до (N)
*/

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

System.Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i ++)
   Console.Write(Math.Pow(i, 2)+ " ");