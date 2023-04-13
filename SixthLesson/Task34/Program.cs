/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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

int EvenChecker(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0) count++;
    }
    return count;
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

/*
bool NumberCheck(int number){
    if(number > 99 || number < 1000){
        return true;
    }else{
        Console.Write("Число не соответствует предполагаемому параметру!");
        return false;
    }
}
*/
int lenght = InputInterface("Введите длину массива: ");

//while(true){
    int min = InputInterface("Введите минимальное трехначное значение эл-та массива: ");
//    if(NumberCheck(min)) break;
//}
//while(true){
    int max = InputInterface("Введите максимальное трехзначное значение эл-та массива: ");
//    if(NumberCheck(max)) break;
//}

int[] array = Randomator(lenght, min, max);
Console.Write($"{PrintArray(array)}\r\n Количество четных чисел -> {EvenChecker(array)}");
