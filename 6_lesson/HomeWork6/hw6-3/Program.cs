// Задача 3: Напишите программу, которая будет создавать копию заданного двумерного массива 
//с помощью поэлементного копирования.

double[,] MassNums(int row, int col)
{
    double[,] arr = new double[row,col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i,j] = Convert.ToDouble(Console.ReadLine());
        }
    Console.WriteLine();
    }
    return arr;
}

void Print(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
    
}

double[,] CopyMass (double[,] array)
{
    double[,] arrayCopy = new double[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < arrayCopy.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCopy.GetLength(1); j++)
        {
            arrayCopy[i,j] = array[i,j];
        }
                
    }
    return arrayCopy;
}

int row = 3;
int column = 4;

Console.WriteLine($"Введите числовые параметры в колличестве {row*column} шт:");
double[,] myMass = MassNums(row,column);
Console.WriteLine("Оригинальный массив: ");
Print(myMass);
Console.WriteLine("Копия:");
double[,] newMass = CopyMass(myMass);
Print(newMass);
