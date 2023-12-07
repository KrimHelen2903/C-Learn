/*
Программа, которая подсчитывает количество четных элементов в массиве целых положительных трёхзначных чисел
и выдает результат на экран. Програма должна иметь метод CountEvenElements, который принимает массив 
целых положительных трёхзнычных чисел и возвращает кол-во чётных элементов в массив.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы должны быть разделены символом табуляции "\t".
Если аргументы командной строки не переданы, программа исполтзует массив по умолчанию, 
который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}

*/

int Prompt(string message)
{
    System.Console.WriteLine(message);                            //Ввод данных
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random[0, 50];                                 //Задаём массив
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int CountEvenElements(int[] array)
{
    int count = 0;  //Задаём метод счётчик
    for (int i = 0; i < array.length; i++)
    {                                                             
        if (array[i] % 2 == 0) ;   //Проверяем на чётность
        count++;
    }
    return count;
}

void PrintArray(int[] arrayOne)
{
    System.Console.WriteLine("Массив");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.WriteLine(arrayOne[i]);                       //Ввыводим массив
        if (i < arrayOne.Length - 1)
            System.Console.WriteLine("\t");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество чётных элементов: {CountEvenElemets(arrayOne)}");
}

int length = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа");
int[] array = GenerateArray(length, min, max);
PrintArray(array);