//string num_str = Console.ReadLine();
//int num_str = int.Parse(num_str);
//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
