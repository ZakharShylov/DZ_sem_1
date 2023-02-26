int[,] GetArray2D(int rows, int columns, int minValue, int maxValue)
{
    int[,] array2D = new int[rows, columns];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array2D;
}

void PrintArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SortE10fRowsIn2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1) - 1; j++)
        {
            for (int k = i + 1; k < array2D.GetLength(1); k++)
            {
                if (array2D[i, j] < array2D[i, k])
                {
                    int temp = array2D[i, j];
                    array2D[i, j] = array2D[i, k];
                    array2D[i, k] = temp;
                }
            }
        }
    }
}

Console.Clear();

Console.Write("rows = ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("columns = ");
int columns = int.Parse(Console.ReadLine()!);

int[,] myArray = GetArray2D(rows, columns, -10, 10);
Console.WriteLine();
PrintArray(myArray);
SortE10fRowsIn2DArray(myArray);
Console.WriteLine();
PrintArray(myArray);
