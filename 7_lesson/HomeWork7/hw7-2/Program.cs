// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

void MeaningOfElement (int rowPosition, int colPosition, double[,] arr)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    if (rowPosition <= row && colPosition <= col)
    {
        Console.WriteLine(arr[rowPosition-1,colPosition-1]);
    }

    else Console.WriteLine("Такого элемента не существует в данном массиве");
}

// задаём кол-во строк и колонок:
int row = new Random().Next(3,8); 
int column = new Random().Next(3,8);
Console.WriteLine($"Массив, размером {row} x {column}:");
      
// создаём массив:
double[,] myMass = CreateMass(row,column);
// выводим массив на экран:
Print(myMass);


Console.WriteLine("Введите нужную строку:");
int position1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите нужную колонку:");
int position2 = int.Parse(Console.ReadLine());
Console.WriteLine($"В позиции [{position1}, {position2}] находится значение: ");

MeaningOfElement(position1, position2, myMass);