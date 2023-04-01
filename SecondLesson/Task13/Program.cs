/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int inputInterface(String message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
while (true){
    int number = inputInterface("Введите число: ");
    if(checkThirdRank(number)){
        Console.WriteLine(getThirdDigit(number));
        break;
    }
}


int getThirdDigit(int number){
    while(number > 999){
        number /= 10;
    }
    return number % 10; 
}

bool checkThirdRank(int number){
    if(number < 100){
        Console.WriteLine("Третьей цифры нет!");
        return false;
    }
    return true;
}