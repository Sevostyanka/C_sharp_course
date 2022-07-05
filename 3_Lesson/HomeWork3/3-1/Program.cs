//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

void Palindrom (string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - это палиндром");
    }
    else 
    Console.WriteLine($"{number} - это не палиндром");
}

string num = "12345";
Palindrom(num);

string a = "12321";
Palindrom(a);