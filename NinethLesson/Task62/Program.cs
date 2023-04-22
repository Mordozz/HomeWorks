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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int size = InputInterface("Введите размер матрицы: ");
int[,] array = new int[size, size]; array = Fill (array);
PrintArray (array);