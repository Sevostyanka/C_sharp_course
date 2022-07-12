// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void Print(int[] arr)
{
    int size = arr.Length;
    Console.Write($"В массиве: ");

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

void PositiveAmount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) count++;
    }
    Console.WriteLine($"Количество чисел больше 0: {count}");
}

int a = int.Parse(Console.ReadLine());
int[] mass = MassNums(a);
Print(mass);
PositiveAmount(mass);
