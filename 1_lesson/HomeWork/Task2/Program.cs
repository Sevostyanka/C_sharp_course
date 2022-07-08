//Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = 0;

if (a > c)
{
    max = a;
}
else 
{
    max = c;
}

if (a > b)
{
    max = a;
}
else 
{
    max = b;
}

if (b > c)
{
    max = b;
}
else
{
    max = c;
}
Console.Write(max);
Console.WriteLine(" - наибольшее число");