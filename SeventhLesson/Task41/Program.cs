/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


int InputInterface(String message){
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}


int[] InputArray(int lenght){
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++){
        array[i] = InputInterface($"Введите значение {i + 1}-го элемента массива: ");
    }
    return array;
} 

int CountPositiveNumbers(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] > 0){
            count++;
        }
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

int lenght = InputInterface("Введите длину массива: ");
int[] array = InputArray(lenght);
Console.Write($"{PrintArray(array)}\r\n Количество полоэительных чисел -> {CountPositiveNumbers(array)}");