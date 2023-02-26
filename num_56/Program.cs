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

void GetRowMinSumofElements(int[,] inArray)
{
    int min = 0;
    int minRow = 1;
    int sum;
    bool isStarted = false;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }

        if (isStarted || sum < min)
        {
            isStarted = true;
            min = sum;
            minRow = i + 1;
        }
    }
    Console.WriteLine($" {minRow} строка");
}

Console.Clear();
Console.Write("rows = ");

int rows = int.Parse(Console.ReadLine()!);
Console.Write("columns = ");

int columns = int.Parse(Console.ReadLine()!);
int[,] myArray = GetArray2D(rows, columns, -10, 10);
Console.WriteLine();
PrintArray(myArray);
GetRowMinSumofElements(myArray);