//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ShortNumder (int b)
{
    while (b > 999)
    {
        b = b / 10;
    }
    return b % 10;
}

int abc = int.Parse(Console.ReadLine());

if (abc > 99)
{
    Console.WriteLine($"В числе {abc} третья цифра - {ShortNumder(abc)}");
}

else 
{
    Console.WriteLine($"В числе {abc} нет третьей цифры");
}
