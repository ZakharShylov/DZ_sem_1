Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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

string GetElementOfArray(int m, int n, int[,] inArray)
{
    if (m < 0 || n < 0) return "m & n должны быть положительными ";
    string result;
    bool hasElement = m <= inArray.GetLength(0) - 1 && n <= inArray.GetLength(1) - 1;
    if (hasElement)
    {
        result = $"{m},{n} -> {inArray[m, n]}";
    }
    else
    {
        result = $"{m},{n} -> такой позиции нет в массиве";
    }
    return result;
}

int rows = new Random().Next(3, 8);
int columns = new Random().Next(3, 8);
int[,] myArray = GetArray(rows, columns, -10, 10);
PrintArray(myArray);
Console.WriteLine();
Console.Write("Введите позицию элемента в двумерном массиве через пробел: ");
int[] position = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
int m = position[0], n = position[1];
Console.WriteLine(GetElementOfArray(m, n, myArray));