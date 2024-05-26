// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Введите первое число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение Функции Аккермана параметров {m} и {n}: {Akkerman(m, n)}");

