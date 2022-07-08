//Задача 2. Напишите программу, которая выводит случайное трёхзначное число,
//и удаляет вторую цифру этого числа



int WithoutSecondDigit (int a)
{
    int num1 = a/100;
    int num3 = a % 10;
    int num2 = (a - (num1*100) - num3)/10;
    int newnum = num1*10 + num3;

    return newnum;
}

int abc = new Random().Next(100,999);
Console.WriteLine(abc);
Console.WriteLine (WithoutSecondDigit(abc));