// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.


int startNumber = ReadUserNumber("Введите начальное число массива: ");
int endNumber = ReadUserNumber("Введите конечное число массива: ");
int arraySize = ReadUserNumber("Введите размер массива: ");
int[] array = NewRandomArray(arraySize, startNumber, endNumber);
Print(array);
Console.WriteLine();
Array.Reverse(array);
Print(array);

int ReadUserNumber(string userText)
{
    Console.Write(userText);
    int numberUser = Convert.ToInt32(Console.ReadLine());
    return numberUser;
}

int[] NewRandomArray(int arrSize, int arrStart, int arrEnd){
    Random rnd = new Random();
    int[] newArr = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        newArr[i] = rnd.Next(arrStart, arrEnd);
    }
    return newArr;
}

void Print(int[] array, int current = 0)

{
    if (current == array.Length) return;
    else
    {
        Console.Write(" " + array[current++]);
        Print(array, current);
    }
}