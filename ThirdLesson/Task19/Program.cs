/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
while(true){
    Console.WriteLine("Введите пятисимвольное число/строку");
    string line = Console.ReadLine();
    Console.WriteLine($"{line} -> {polindromValidation(line)}");


    string polindromValidation(string line){
        for (int i = 0; i < line.Length / 2; i++) {
//            Console.WriteLine($"From left: {line[i]}, from right: {line[line.Length - i - 1]}");
            if (line[i] != line[line.Length - i - 1]) {
                return "нет";
            }
        }
        return "да";
    }
}



