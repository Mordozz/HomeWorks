/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


int N = int.Parse(Console.ReadLine());
string line = "";
double cube;

string cubeDeliverence(int N){
    for (int i = 1; i <= N; i++) {
        cube = Math.Pow(i, 3);
        if(i != N){
            line += cube + ", ";
        }else{
            line += cube;
        }
    }
    return line;
}
Console.WriteLine($"{N} -> {cubeDeliverence(N)}");