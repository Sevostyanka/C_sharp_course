// Задача 3. Напишите программу, которая на вход принимает число N, 
//а на выходе выдаёт произведение чисел от 1 до N

int Mult(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++) mult = mult*i;
    
    return mult;
}
int a = 5;
Console.WriteLine($"{a} -> {Mult(a)}");