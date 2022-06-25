//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

int a = int.Parse(Console.ReadLine());

if (a % 2 == 1)
{
    Console.Write(a);
    Console.Write(" - нечётное");
}
else if (a % 2 == 0)
{
    Console.Write(a);
    Console.Write(" - чётное");
}