/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int InputInterface(String message){
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

String PrintArray(int[,] array){
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    string str = "[";

    for(int i = 0; i < m; i++){
        if (i > 0){str += "]\r\n[";}
        for(int j = 0; j < n; j++){
            str += array[i,j];
            if (j < n-1) { str += " "; }
        }
    }
    str += "]";
    return str;
}

int[,] GenerateArray(int m, int n){
    Random rand = new Random();
    int[,] array = new int[m,n];

    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = rand.Next(10);
        }
    }
    return array;
}

String AvgReturn(int[,] array){
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    string str = "";
    double avg = 0.0;
    double sum = 0;
    for(int j = 0; j < n; j++){
        sum = 0;
        for(int i = 0; i < m; i++){
            sum += array[i,j];
        }
        avg = sum/m;
        str += avg + "; ";
    }
    return str;
}

int m = InputInterface("Введите количество строк: ");
int n = InputInterface("Введите количество столбцов: ");
int[,] matrix = GenerateArray(m, n);
Console.Write($"{PrintArray(matrix)}\r\n");
Console.Write($"Среднее арифметическое каждого столбца: {AvgReturn(matrix)}");