// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 2 = 10
// 3 = 11
// 45 = 101101

void Binary(int number)
{
    string Dec = "";
    while (number > 0)
    {
        Dec = number % 2 + Dec;
        number /= 2;
    }
    Console.Write(Dec);
}

Binary(45);