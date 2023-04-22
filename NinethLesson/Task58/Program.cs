/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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


int[,] MultiplyMatrices(int[,] a, int[,] b)
{
    int aRows = a.GetLength(0);
    int aCols = a.GetLength(1);
    int bRows = b.GetLength(0);
    int bCols = b.GetLength(1);

    int[,] result = new int[aRows, bCols];
    for (int i = 0; i < aRows; i++)
    {
        for (int j = 0; j < bCols; j++)
        {
            int sum = 0;
            for (int k = 0; k < aCols; k++)
            {
                sum += a[i, k] * b[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}

int m = InputInterface("Введите количество строк: ");
int n = InputInterface("Введите количество столбцов: ");
int[,] matrix1 = GenerateArray(m, n);
int[,] matrix2 = GenerateArray(m, n);
Console.Write($"{PrintArray(matrix1)}\r\n----------\r\n{PrintArray(matrix2)}\r\n");
int[,] resultingMatrix = MultiplyMatrices(matrix1, matrix2);
Console.Write($"Произведение матриц: \r\n{PrintArray(resultingMatrix)}");