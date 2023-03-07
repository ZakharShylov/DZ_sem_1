void WriteNumbers(int m, int n)
{
    if (m <= n)
    {
        WriteNumbers(m + 1, n);
        Console.Write($"{m} ");
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
WriteNumbers(m, n);
