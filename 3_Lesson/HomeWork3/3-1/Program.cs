//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

// int ConverterInArray(int num)
// {
//     int n1 = num/10000;
//     int n2 = num/1000%10;
//     int n3 = num/100%10;
//     int n4 = num/10%10;
//     int[] array = {n1,n2,n3,n4,n5};
//     return array;

// }

// void Palindrom (int[] num)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         Console.WriteLine("Это палиндром");
//     }
//     else
//     {
//         Console.WriteLine("Это не палиндром");
//     }
// }

// int a = 12345;

// Console.WriteLine(ConverterInArray(a));
// Palindrom(ConverterInArray(a));

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