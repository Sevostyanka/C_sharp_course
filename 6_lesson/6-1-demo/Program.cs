// Задача 1. Демо. Напишите программу, котрая перевернёт одномерный массив. 
//Последний элемент будет на 1м месте, а первй на последнем.

int[] MassNum(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from,to);
    }
    return arr;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int[] RevMas(int[] array)
{
    int size = array.Length - 1;
    for (int i = 0; i <= size / 2; i++)
    {
        (array[i], array[size-i]) = (array[size-i], array[i]);
    }
    return array;
}

int[] Massiv = MassNum(6,1,21);
Print(Massiv);
RevMas(Massiv);
Print(Massiv);