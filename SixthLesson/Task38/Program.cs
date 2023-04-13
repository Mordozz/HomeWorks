/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


int InputInterface(String message){
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int[] Randomator(int lenght, int min, int max){
    Random rand = new Random();
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++){
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

int Difference(int[] array){
    int diff = 0; 
    int min = array[0]; 
    int max = array[0];

    
    for(int i = 0; i < array.Length; i ++){
        if(array[i] < min){
            max = array[i];
        }
        if(array[i] > max){
            min = array[i];
        }

    }
    diff = max - min;
    return Math.Abs(diff);
}

String PrintArray(int[] array){
    string str = "[";
    for(int i = 0; i < array.Length; i++){
        if(i < array.Length - 1){
            str += ($"{array[i]}, ");
        }else{
            str += ($"{array[i]}]");
        }
    }
    return str;
}



int lenght = InputInterface("Введите длину массива: ");
int min = InputInterface("Введите минимальное трехначное значение эл-та массива: ");
int max = InputInterface("Введите максимальное трехзначное значение эл-та массива: ");


int[] array = Randomator(lenght, min, max);
Console.Write($"{PrintArray(array)}\r\n Разница между максимальным и минимальным эл-том -> {Difference(array)}");
