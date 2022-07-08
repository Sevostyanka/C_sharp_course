// Задача 2. Напишите программу, которая принимает на вход число,
// а на выходе выдаёт сумму цифр этого числа.

double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;
    for (int i = 0; i < length; i++)
    {
        double m = char.GetNumericValue(n[i]);
        sum = sum + m;
    }

    return sum;
}

int n = int.Parse(Console.ReadLine());

Console.WriteLine(DigitSum(n));

// string n = num.ToString() - придаём числовой переменной num строковое значение, и называем ее n;
