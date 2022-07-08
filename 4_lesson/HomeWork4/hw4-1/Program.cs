// Задача 1. Напишите цикл, который принимает на вход два числа (А и В) 
//и возводит число А в натуральную степень В.

int Power(int a, int b)
{
    int result = 1;
    for (int i = 1; i <=b; i++)
    {
        result = result * a;
    }
    return result;
}
int a = 3;
int b = 4;
Console.WriteLine($"{a},{b} => {Power(a,b)}");
