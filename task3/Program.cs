﻿// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] CreateArrayRndInt(int size, int min, int max)
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
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");

    }
    Console.Write("]");
}

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write($"{array[index]} ");
    PrintArrayReverse(array, index - 1);
}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Элементы массива в обратном порядке:");
PrintArrayReverse(arr, arr.Length - 1);

