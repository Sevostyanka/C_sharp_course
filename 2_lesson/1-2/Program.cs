// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int MaxNam(int num)
{
    if (num % 10 > num / 10)
    {
        return num % 10;
    }
    else 
        return num / 10;
}

int SecondNum = new Random().Next(10, 100);
MaxNam(SecondNum);
Console.WriteLine($"в числе {SecondNum} наибольшая цифра {MaxNam(SecondNum)}");