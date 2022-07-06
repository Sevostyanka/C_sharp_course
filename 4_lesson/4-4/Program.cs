// Задача 4. Напишите программу, которая будет выводить массив из 8 элементов, заполненный случайными 0 или 1. 

void Massiv()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write($"{array[i]} ");
    }
}

Massiv();