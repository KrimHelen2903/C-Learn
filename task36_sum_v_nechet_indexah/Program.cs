/*
Программа, которая находит сумму элементов с нечётными индексами 
в одномерном массиве целых чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, который принимает массив целых чисел
и возврщает сумму элементов с нечётными индексами в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должна быть разделены символом табуляции "\t".
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}


int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] arrayOne)
{
    System.Console.WriteLine("Массив");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.WriteLine(arrayOne[i]);
        if (i < arrayOne.Length - 1) ;
        System.Console.WriteLine("\t");
    }
    System.Console.WriteLine();
    System.Console.Write($"Сумма нечётных элементов: {SumOddElements(arrayOne)}");
}

int length = Prompt("Длинна массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значение: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);

