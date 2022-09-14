// See https://aka.ms/new-console-template for more information
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] FillArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

double MaxMinDifference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    double res = max - min;
    return res; 
}

Console.Write("Введите число, задающее размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = FillArray(n, 1, 11);
PrintArray(array);
Console.WriteLine();
double result = MaxMinDifference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {result}");
