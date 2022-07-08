//Задача 15. Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int day = int.Parse(Console.ReadLine());

if (day >= 1 & day < 6)
{
    Console.WriteLine("Это будний день");
}

else if (day > 7 ^ day < 1)
{
    Console.WriteLine("Используйте цифры от 1 до 7");
}

else if (day == 6 ^ day == 7)
{
    Console.WriteLine("Это выходной день");
}