// Задача 3. Напишите программу, которая выдаёт массив из 8ми элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции (пригодится на будущее).

int[] NewArray(int size)
{
    int[] arr = new int[size];
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int size = 12;
PrintArray(NewArray(size));