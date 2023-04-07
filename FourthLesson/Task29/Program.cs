int InputInterface(String message){
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int[] Randomator(int lenght, int min, int max){
    int[] array = new int[lenght];
    Random random = new Random();
    for(int i = 0; i < lenght; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array){
    Console.Write("[");
    for(int i = 0; i < array.Length; i++){
        if(i < array.Length - 1){
            Console.Write($"{array[i]}, ");
        }else{
        Console.Write($"{array[i]}]");
        }
    }
}
int lenght = InputInterface("Введите длину массива: ");
int min = InputInterface("Введите минимальное значение эл-та: ");
int max = InputInterface("Введите максимальное значение эл-та: ");
int[] array = Randomator(lenght, min, max);
PrintArray(array);