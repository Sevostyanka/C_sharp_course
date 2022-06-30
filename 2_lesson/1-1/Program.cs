//Задача 1. Напишите программу, которая на вход получает трехзначное число, на выходе показывает
// последнюю чифру этого числа. Например 543 -> 3.

int TakeNum(int num)
{
    return num % 10;
}

Console.WriteLine(TakeNum(678));
Console.WriteLine(TakeNum(67873553));