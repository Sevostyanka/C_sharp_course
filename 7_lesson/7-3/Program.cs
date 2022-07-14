// Задайте двумерный массив. Найдите сумму элементов главной диагонали.

int SumElDiag (int[,] Array)
{
    int rows = Array.GetLength(0);
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += Array[i,i];
    }
    return sum;
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 101);
Print(arr_1);

Console.WriteLine(SumElDiag(arr_1));


Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 101);
Print(arr_1);


