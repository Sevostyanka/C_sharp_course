//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit (int a)
{
    int num3 = a % 10;
    return num3;
}

int ShortNumder (int b)
{
    int count = 0;
    int bShort = b;
    while (bShort > 999)
    {
        bShort = b / 10;
        count= count +1;
    }
    return bShort;
}

int abc = int.Parse(Console.ReadLine());

if (abc < 999 & abc > 99)
{
    Console.WriteLine($"В числе {abc} третья цифра - {ThirdDigit(abc)}");
}

else if (abc < 100)
{
    Console.WriteLine($"В числе {abc} нет третьей цифры");
}

else 
{
    Console.WriteLine($"В числе {abc} третья цифра - {ThirdDigit(ShortNumder(abc))}");
}