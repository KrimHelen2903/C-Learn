/*\
Программа которая, перевернёт одномерный массив, последний элемент будет на первом месте,
а первый будет на последенем. Не отсартирует а перевернет.
*/

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}


int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        System.Console.Write(",");
    }
    
        Console.WriteLine("]");
}

int[] Revers(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = temp;
    }
    return array;
}

int size = Prompt("Задай размер массива: ");
int[] userArray = GetRnd(size);
PrintArray(userArray);
System.Console.WriteLine();
Revers(userArray);
PrintArray(userArray);



