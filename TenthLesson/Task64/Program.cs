/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int InputInterface(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

void RecursionDecrease(int n)
{
    Console.Write(n);
    if (n > 1)
    {
        Console.Write(", ");
        RecursionDecrease(n - 1);
    }
}


int n = InputInterface("Введите значение N: ");
RecursionDecrease(n);
