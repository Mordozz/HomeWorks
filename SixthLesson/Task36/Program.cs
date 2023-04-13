/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

int SumNotEven(int[] array){
    int sum = 0;
    for(int i = 0; i < array.Length; i += 2){
        sum += array[i];
    }
    return sum;
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
Console.Write($"{PrintArray(array)}\r\n Сумма нечётных эл-тов -> {SumNotEven(array)}");
