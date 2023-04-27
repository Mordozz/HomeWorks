/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int InputInterface(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackerman(m - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));
}

int m = InputInterface("Задайте значение M: ");
int n = InputInterface("Задайте значение N: ");
int result = Ackerman(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
