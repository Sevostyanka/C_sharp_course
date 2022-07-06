// Задача 2. Задаем число и программа выдаёт, сколько цифр в числе.
// 345 -> 3
// 26543 -> 5

int Count (int num)
{
    string result = num.ToString();
    return result.Length;
}
int a = 45;
Console.WriteLine($"{a} -> {Count(a)}");
