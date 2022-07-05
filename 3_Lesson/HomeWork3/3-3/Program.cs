// Задача 23. Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int num)
{
    int i = 1;
    while (i<=num)
    {
        Console.WriteLine($"{i} => {Math.Pow(i,3)}");
        i++;
    }
}


int n = new Random().Next(1,20);
Console.WriteLine(n);
Cube(n);