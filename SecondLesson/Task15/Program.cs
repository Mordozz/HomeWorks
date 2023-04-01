/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int inputInterface(String message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


int dayOfTheDay = inputInterface("Введите день недели: ");
if (legitDay(dayOfTheDay)){
    
    Console.WriteLine($"У нас выходной? \r\n {dayOfTheDay} - {isWeekDay(dayOfTheDay)}");
}

bool legitDay(int dayOfTheDay){
    if(dayOfTheDay >= 1 && dayOfTheDay <=7){
        return true;
    }else{
        Console.WriteLine("Такого дня недели не существует!");
        return false;
    }
}

string isWeekDay(int number){
    
    if(dayOfTheDay == 6 || dayOfTheDay == 7){
        return "Да";
    }else{
        return "Нет";
    }
}