/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int InputInterface(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

string PrintArray(int[,,] array)
{
    string str = "";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            for (int k = 0; k < array.GetLength(2); k++)
            {
                str += $"{array[i, j, k]}({i},{j},{k})\r\n";
            }
        }
    }
    return str;
}

int[,,] GenerateArray3D(int m, int n, int d)
{
    Random rand = new Random();
    int[,,] array3D = new int[m, n, d];
    HashSet<int> usedValues = new HashSet<int>();
    int value = 0;

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                do
                {
                    value = rand.Next(10, 100); 
                } while (usedValues.Contains(value)); 

                array3D[i, j, k] = value;
                usedValues.Add(value);
            }
        }
    }
    return array3D;
}

int m = InputInterface("Введите количество x: ");
int n = InputInterface("Введите количество y: ");
int d = InputInterface("Введите количество z: ");
int[,,] matrix3d = GenerateArray3D(m, n, d);
Console.WriteLine(PrintArray(matrix3d));