/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int InputInterface(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

string PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    string str = "[";

    for (int i = 0; i < m; i++)
    {
        if (i > 0) { str += "]\r\n["; }
        for (int j = 0; j < n; j++)
        {
            str += array[i, j];
            if (j < n - 1) { str += " "; }
        }
    }
    str += "]";
    return str;
}

int[,] GenerateArray(int m, int n)
{
    Random rand = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(10);
        }
    }
    return array;
}


int lowestSumInRow(int[,] array)
{
    int minSum = int.MaxValue;
    int minSumRow = -1;
    int rowSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRow = i;
        }
    }
    return minSumRow;
}

int m = InputInterface("Введите количество строк: ");
int n = InputInterface("Введите количество столбцов: ");
int[,] matrix = GenerateArray(m, n);
Console.Write($"{PrintArray(matrix)}\r\n");

Console.Write($"Строка с минимальной суммой элементов: {lowestSumInRow(matrix) + 1}");