// Задача 4. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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
// нахожу минимальное значение.
int MinimumElement (int[,] arr)
{
    int min = arr[0,0];
    int count = 0;
    while(count < arr.GetLength(0) * arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (min > arr[i,j]) min = arr[i,j];
            }
        }
        count++;
    }
    return min;
}

void ShortMatrix(int[,] arr, int min)
{
    int row = 0;
    int col = 0;
    // нахожу индексы минимального значения:
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == min) 
            {
                row = i;
                col = j;
                Console.WriteLine($"Минимальный элемент таблицы => {min} на позиции [строка:{row+1}, столбец: {col+1}].");
            }
            
        }
        
    }
    // вывожу таблицу игнорируя строку и столбец, где минимальное значение
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == row || j == col) continue;
            else Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    // Console.WriteLine();
}

Console.WriteLine("Задайте кол-во строк таблицы:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте кол-во столбцов таблицы:");
int column = int.Parse(Console.ReadLine());

Console.WriteLine("Сгенерирована матрица:");
int[,] myMass = MassNums(row,column,1,100);
Print(myMass);

int min = MinimumElement(myMass);

Console.WriteLine("Укороченная таблица:");
ShortMatrix(myMass,min);