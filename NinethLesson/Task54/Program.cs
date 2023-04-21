/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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


int[,] SortArray(int[,] array)
{
    int[] tempArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempArray[j] = array[i, j];
        }
        Array.Sort(tempArray);
        Array.Reverse(tempArray);

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = tempArray[j];
        }
    }
    return array;
}
/*
int[,] SortArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"i{i} = ");
//        Console.Write($"{i};{array.GetLength(1) - 1}");  
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
//            Console.Write($"{array[i,j]}\n");
            for (int d = j + 1; d < array.GetLength(1); d++)
            {
//                Console.Write($"j{d} = {array[i,d]}\n");
                if (array[i, d] > array[i, j])
                {
//                    Console.Write($"d{d} = {array[i, d]}\n");
                    temp = array[i, d];
//                    Console.Write($"Debug temp = {temp}, arr[i,j] = {array[i,j]}\r\n");
                    array[i, d] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}
*/

int m = InputInterface("Введите количество строк: ");
int n = InputInterface("Введите количество столбцов: ");
int[,] matrix = GenerateArray(m, n);
Console.Write($"{PrintArray(matrix)}\r\n");

int[,] sortedMatrix = SortArray(matrix);
Console.Write($"Отсортированная матрица по убыванию каждой строки: \r\n{PrintArray(sortedMatrix)}");