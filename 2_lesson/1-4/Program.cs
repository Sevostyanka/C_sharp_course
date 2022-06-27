//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.


void OneOfNum(int num)
{       
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");        
    }    
}
int a = new Random().Next(0,300);
int b = new Random().Next(300,1000);
Console.WriteLine($"Даны числа {a} и {b}. Кратны ли они одновременно 7 и 23?");
OneOfNum(a);
OneOfNum(b);
