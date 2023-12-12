// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

int startNumber = ReadUserNumber("Введите начальное число: ");
int endNumber = ReadUserNumber("Введите конечное число: ");
SumNumber(startNumber, endNumber);

int ReadUserNumber(string userText)
{
    Console.Write(userText);
    int numberUser = Convert.ToInt32(Console.ReadLine());
    return numberUser;
}

void SumNumber(int numStart, int numEnd)
{

    if (numStart > numEnd) return;
    else
    {
        Console.Write(numStart + " ");
        numStart++;
        SumNumber(numStart++, numEnd);
    }
}