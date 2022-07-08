//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//  456 -> 5
//  782 -> 8
//  918 -> 1

int SecondDigit (int a)
{
    int num1 = a/100;
    int num3 = a % 10;
    int num2 = (a - (num1*100) - num3)/10;

    return num2;
}

int abc = new Random().Next(100,1000);
Console.WriteLine ($"В трёхначном числе {abc} вторая цифра - {SecondDigit(abc)}");