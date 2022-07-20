// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов и писать номер этой строки.

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

//ищем строку с наименьшей суммой элементов:

void MinStringNumber (int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int tempSum = 0;
    int maxSum = 0;
    int strNumber = 0;
    //нахожу максимальную сумму, чтобы от нее отталкиваться при нахождениии минимальной
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            maxSum = maxSum + arr[i,j];
        }
    }
    // нахожу минимальную сумму и ее строку
    int minSum = maxSum;    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            tempSum = tempSum + arr[i,j];
        }
        if (tempSum <= minSum) 
        {
            minSum = tempSum;
            strNumber = i+1;
            tempSum = 0;
        }
        else tempSum = 0;

    }
    Console.WriteLine($"Строка c наименьшей суммой элементов: {strNumber}-я.");
    Console.WriteLine($"Сумма равна {minSum}.");
        
}

// Параметры массива:
Console.WriteLine("Введите количество строк:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стоблцов:");
int column = int.Parse(Console.ReadLine());
int from = 1;
int to = 100;

Console.WriteLine("Сгенерирован новый массив:");
int[,] myMass = MassNums(row,column, from, to);
Print(myMass);

// ф-ция с выводом номера строки:
MinStringNumber(myMass);
