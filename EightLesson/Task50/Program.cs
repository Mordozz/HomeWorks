/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет
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

double CoordinatValue(double[,] array, int col, int row){
    double value = 0;
    if (row - 1 < 0 
    || row - 1 >= array.GetLength(0) 
    || col - 1 < 0 
    || col - 1 >= array.GetLength(1)){
        Console.WriteLine("Указанной координаты массива не существует.");
        return 0;
    }else{
        value = array[col - 1, row - 1];
        Console.WriteLine($"Значение элемента [{row},{col}]: {value}");
        return value;
    }
}

int m = InputInterface("Введите количество строк: ");
int n = InputInterface("Введите количество столбцов: ");
double[,] matrix = GenerateArray(m, n);
Console.Write($"{PrintArray(matrix)}\r\n");

int row = InputInterface("Укажите номер строки: ");
int col = InputInterface("Укажите номер столбца: ");
double value = CoordinatValue(matrix, col, row);
