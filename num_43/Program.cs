Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

double ResX(int b1, int k1, int b2, int k2)
{
    double x1 = b2 - b1;
    double x2 = k1 - k2;
    double x = x1 / x2;
    return x;
}

double ResY(int b1, int k1, double x)
{
    double y = (k1 * x) + b1;
    return y;
}

Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine()!);


double x = ResX(b1, k1, b2, k2);
double y = ResY(k1, b1, x);

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y}) ");