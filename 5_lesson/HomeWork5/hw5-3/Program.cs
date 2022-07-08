//Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] MassNums(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        // arr[i] = new Random().NextDouble()*(10- (-3.5)) -3.5;

        arr[i] = Math.Round(new Random().NextDouble()*(10- (-3.5)) -3.5, 2);
    }
       
    return arr;
}

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write(($"{arr[i]}; "));
    }
    Console.WriteLine();
}

double Diff(double[] array)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if(array[i] < min) min = array[i];
    }
    double dif = max - min;
    return dif;

}

int size = 5;
double[] mass = MassNums(size);
Print(mass);
Console.WriteLine($"Разница max и min значений в массиве = {Diff(mass)}.");