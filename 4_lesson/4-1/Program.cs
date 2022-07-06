// Задача 1. Напишите программу, которая принимает на вход число А и выдаёт сумму чисел от 1 до А.

int SumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)all_sum = all_sum + i;
    
    return all_sum;
}

int a = 10;

Console.WriteLine(SumNum(a));