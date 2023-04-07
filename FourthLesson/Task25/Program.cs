/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int InputInterface(String message){
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int DegreeRetrive(int num, int dgr){
    int result = 1;
    for(int i = 0; i < dgr; i++){
        result *= num;
    }
    return result;
}


int a = InputInterface("Введите число: ");
int b = InputInterface("Ведите степень этого числа: ");
Console.Write(DegreeRetrive(a, b));