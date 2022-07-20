// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] MultSquareMatrix (int[,] arr1, int[,] arr2)
{
    int length = arr1.GetLength(1);
    int[,] matr = new int[length,length];

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < length; k++)
            {
                matr[i,j] = matr[i,j] + arr1[i,k] * arr2[k,j];
            }
            
        }
    }
    return matr;
}


int from = 1;
int to = 10;
Console.WriteLine("Введите количество строк и столбцов квадратных матриц:");
int row = int.Parse(Console.ReadLine());
int column = row;

Console.WriteLine("Матрица 1:");
int[,] matrix1 = MassNums(row,column,from,to);
Print(matrix1);
Console.WriteLine("Матрица 2:");
int[,] matrix2 = MassNums(row,column,from,to);
Print(matrix2);

int[,] multipl = MultSquareMatrix(matrix1,matrix2);
Print(multipl);
