// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double[] MassNums(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double[] Point (double[] a, double[] b)
{
    double x = (b[1] - a[1])/(a[0] - b[0]);
    double y = a[0] * x + a[1];
    double[] po = {Math.Round(x,2),Math.Round(y,2)};
    return po;
}

int n = 2;
Console.WriteLine("Введите два параметра первой прямой");
double[] Line1 = MassNums(n);
Print(Line1);
Console.WriteLine("Введите два параметра второй прямой");
double[] Line2 = MassNums(n);
Print(Line2);

Console.Write("Точка пересечения двух прямых: ");
Print (Point(Line1, Line2));

