// Задача 2. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-2, 8);
    }
    return arr;
}

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int OddSum(int[] array)
{
    int oddsum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            oddsum = oddsum + array[i];
        }
    }
    return oddsum;
}

int size = 5;
int[] mass = MassNums(size);
Print(mass);
Console.Write($"{OddSum(mass)} -> это сумма нечётных чисел в нашем массиве.");