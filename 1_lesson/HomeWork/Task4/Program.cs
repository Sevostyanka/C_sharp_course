//Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int n = int.Parse(Console.ReadLine());
int temp = 2;

while (temp <= n)
{
    Console.WriteLine(temp);
    temp = temp + 2;
}