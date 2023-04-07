/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int InputInterface(String message){
    Console.Write(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int Combiner(int num){
    int sum = 0;
    while (num > 0){
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int line = InputInterface("Введите число: ");
Console.Write($"Сумма цифр в числе {line}: {Combiner(line)}");