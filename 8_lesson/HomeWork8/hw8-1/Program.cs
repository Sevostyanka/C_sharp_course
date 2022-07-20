// Задача 1: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

int[,] ModMass (int[,] arr)
{
    int count = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    while (count <= row*column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column-1; j++)
            {
                if (arr[i,j] < arr[i,j+1]) 
                {
                    (arr[i,j], arr[i,j+1]) = (arr[i,j+1], arr[i,j]);
                }
            }
        }
        count++;
    }
    return arr;
}
Console.WriteLine("Введите количество строк:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int column = int.Parse(Console.ReadLine());

Console.WriteLine("Сгенерирована таблица с числами от -10 до 10:");
int from = -10;  
int to = 10; 
int[,] myMass = MassNums(row,column,from,to);
Print(myMass);

Console.WriteLine("Строки отсортированы по возрастанию:");
Print(ModMass(myMass));
