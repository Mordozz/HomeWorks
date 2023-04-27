/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int InputInterface(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int GetSumOfNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + GetSumOfNaturalNumbers(m + 1, n);
    }
}

int m = InputInterface("Задайте значение M: ");
int n = InputInterface("Задайте значение N: ");
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n}: {GetSumOfNaturalNumbers(m, n)}");