//Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте меньшее значениe:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте большее значение:");
int n = int.Parse(Console.ReadLine());

int Sum(int m, int n)
{
    if( n <= m ) return m;
    return Sum(m, n-1)+ n;
}

Console.WriteLine($"Ответ: {Sum(m,n)}");