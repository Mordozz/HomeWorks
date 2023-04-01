/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int inputInterface(String message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
while (true){
    int a = inputInterface("Введите трёхзначное число: ");

    if(a > 99 & a < 1000){
        int secondDigit = a % 100 / 10; 
        Console.Write(secondDigit);
        break;
    }else{
        Console.Write("Число не трёхзначное! \r\n");
        
    }
}

