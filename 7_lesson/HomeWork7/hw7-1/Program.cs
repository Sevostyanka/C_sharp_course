// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


double[,] CreateMass(int row, int col) // ф-ция создаёт вещественный массив
{
    double[,] arr = new double[row,col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble()*(10- (-10)) -10, 2);
        }
    }
    return arr;
}

void Print(double[,] matr) // ф-ция выводит массив на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"*{matr[i, j]}* ");
        }
        Console.WriteLine();
    }
}

// задаём кол-во строк и колонок:
int row = new Random().Next(3,8); 
int column = new Random().Next(3,8);
Console.WriteLine($"Массив, размером {row} x {column}:");
// создаём массив:
double[,] myMass = CreateMass(row,column);
// выводим массив на экран:
Print(myMass);
