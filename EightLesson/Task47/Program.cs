/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int InputInterface(String message){
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

String PrintArray(double[,] array){
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    string str = "[";

    for(int i = 0; i < n; i++){
        if (i > 0){str += "]\r\n[";}
        for(int j = 0; j < m; j++){
            str += array[j,i];
            if (j < m-1) { str += " "; }
        }
    }
    str += "]";
    return str;
}

double[,] GenerateArray(int m, int n){
    Random rand = new Random();
    double[,] array = new double[m,n];

    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = Math.Round(rand.NextDouble(), 1);
        }
    }
    return array;
}

int m = InputInterface("Введите количество строк: ");
int n = InputInterface("Введите количество столбцов: ");
double[,] matrix = GenerateArray(m, n);
Console.Write(PrintArray(matrix));