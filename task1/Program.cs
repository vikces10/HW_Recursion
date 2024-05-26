// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNumbersAscending(int start, int end)
{
    if (start > end)
    {
        return;
    }

    Console.Write($"{start} ");
    PrintNumbersAscending(start + 1, end);
}

void PrintNumbersDescending(int start, int end)
{
    if (start < end)
    {
        return;
    }

    Console.Write($"{start} ");
    PrintNumbersDescending(start - 1, end);
}

Console.WriteLine("Введите первое число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.WriteLine("Оба числа M и N должны быть натуральными");
    return;
}

if (m <= n)
{
    Console.WriteLine($"Натуральные числа от {m} до {n}:");
    PrintNumbersAscending(m, n);
}
else
{
    Console.WriteLine($"Натуральные числа от {m} до {n}:");
    PrintNumbersDescending(m, n);
}

