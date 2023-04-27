/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/



int InputInterface(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int[,] Fill(int[,] array)
{
    int num = 1;
    int x = 0;
    int y = 0;
    int dir = 0;

    while (num <= array.GetLength(0) * array.GetLength(1))
    {
        array[x, y] = num;

        switch (dir)
        {
            case 0: // Идём вправо
                if (y == array.GetLength(1) - 1 || array[x, y + 1] != 0) // право дошли
                {
                    x++;
                    dir = 1;
                }
                else
                {
                    y++;
                }
                break;
            case 1: // вниз
                if (x == array.GetLength(0) - 1 || array[x + 1, y] != 0) // вниз дошли
                {
                    y--;
                    dir = 2;
                }
                else
                {
                    x++;
                }
                break;
            case 2: // ВЛево
                if (y == 0 || array[x, y - 1] != 0) // лево дошли
                {
                    x--;
                    dir = 3;
                }
                else
                {
                    y--;
                }
                break;
            case 3: // наверх
                if (x == 0 || array[x - 1, y] != 0) // верх дошли
                {
                    y++;
                    dir = 0;
                }
                else
                {
                    x--;
                }
                break;
        }
        num++;
    }

    return array;
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
            str += array[i, j].ToString("D2");
            if (j < n - 1) { str += " "; }
        }
    }
    str += "]";
    return str;
}

int size = InputInterface("Введите размер матрицы: ");
int[,] array = new int[size, size]; 
int[,] matrix = Fill(array);
Console.WriteLine(PrintArray(matrix));