

Console.Clear();
double[,] GetArray(int row, int col, double minValue, double maxValue)
{
    double[,] array = new double[row, col];
    Random random = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = Math.Round(minValue + random.NextDouble() * (maxValue - minValue), 1);
        }
    }
    return array;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] myArray = GetArray(rows, columns, -9.9, 9.9);
Console.WriteLine();
PrintArray(myArray);
