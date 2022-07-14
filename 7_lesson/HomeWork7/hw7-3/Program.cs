// Задача 3: Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


// ф-ция создаёт массив целых чисел:
int[,] CreateMass(int row, int col) 
{
    int[,] arr = new int[row,col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i,j] = new Random().Next(1,100);
        }
    }
    return arr;
}

// ф-ция - среднее арифметическое элементов в каждом столбце:
double[] ArithmeticMiddle(int[,] arr) 
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    double[] arrMiddle = new double [col];
    

    for (int j = 0; j < col; j++)
    {
        double count = 0;
        for (int i = 0; i < row; i++)
        {
            count = count + arr[i,j];
            arrMiddle[j] = count/row;
            arrMiddle[j] = Math.Round(arrMiddle[j],2);
        }
        
    }
    return arrMiddle;
}

// ф-ция выводит матрицу на экран:
void PrintMatrix(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//печатает одномерный массив:
void PrintMass (double[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ; ");
    }
}

// Задаём параметры матрицы:
int row = new Random().Next(3,10);
int column = new Random().Next(3,10);


int[,] myMass = CreateMass(row,column);
Console.WriteLine($"Новый массив {row} x {column}:");
Console.WriteLine("-----------------------------");
PrintMatrix(myMass);
Console.WriteLine("-----------------------------");

double[] midMass = ArithmeticMiddle(myMass);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintMass(midMass);