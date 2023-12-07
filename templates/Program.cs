//Шпаргалки



//Ввод данных пользователя

int Prompt(string message)
{
    Console.WriteLine(message);                            
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

//-------------------------------------------------------

//Задаём массив/генерируем

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random[0, 50];                                 
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

//--------------------------------------------------------

int CountEvenElements(int[] array)
{
    int count = 0;  //Задаём метод счётчик
    for (int i = 0; i < array.length; i++)  //цикл for
    {                                                             
        if (array[i] % 2 == 0) ;   //Проверяем на чётность
        count++;
    }
    return count;
}





