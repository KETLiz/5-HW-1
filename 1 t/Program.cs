// See https://aka.ms/new-console-template for more information
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i]%2 == 0) count += 1;
    return count;
}

Console.WriteLine("Введите число, задающее размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(n);
PrintArray(arr);
Console.WriteLine();
int result = EvenNumber(arr);
Console.WriteLine($"Количество четных элементов массива = {result}");