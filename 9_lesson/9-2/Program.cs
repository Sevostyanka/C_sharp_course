// // 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Sequence(int M, int N)
{
    if (N < M) return;
    Sequence(M, N-1);
    Console.Write($"{N}, ");
}
Sequence(M, N);
