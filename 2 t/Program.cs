// See https://aka.ms/new-console-template for more information
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
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

int OddNumbersIndexSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0) sum += array[i];
    }
    return sum;
}

Console.WriteLine("Введите число, задающее размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArray(n, -10, 10);
PrintArray(arr);
Console.WriteLine();
int sum = OddNumbersIndexSum(arr);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях равна {sum}");