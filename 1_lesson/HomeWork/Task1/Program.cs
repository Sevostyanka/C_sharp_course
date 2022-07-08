//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write(a);
    Console.WriteLine(" - больше");
    Console.Write(b);
    Console.WriteLine(" - меньше");
}
if (a < b)
{
    Console.Write(b);
    Console.WriteLine(" - больше");
    Console.Write(a);
    Console.WriteLine(" - меньше");
}