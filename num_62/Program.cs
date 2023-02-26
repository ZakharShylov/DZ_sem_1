// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetArray2D(int m, int n)
{
    int[,] array2D = new int[m, n];
    return array2D;
}

void FillArraySpirally(int[,] array2D)
{
    int m = array2D.GetLength(0);
    int n = array2D.GetLength(1);
    int k = 1;
    bool[,] visited = new bool[m, n];
    bool isEnd = false;
    int x = 0, y = 0;


while (!isEnd)
{
    isEnd = true;

    while (y < n - 1 && !visited[x, y + 1])
    {
        isEnd = false;
        array2D[x, y] = k++;
        visited[x, y] = true;
        ++y;
    }

    while (x < m - 1 && !visited[x +1, y])
    {
        isEnd = false;
        array2D[x, y] = k++;
        visited[x, y] = true;
        ++x;
    }

    while (y > 0  && !visited[x, y - 1])
    {
        isEnd = false;
        array2D[x, y] = k++;
        visited[x, y] = true;
        --y;
    }

    while (x > 0 && !visited[x - 1, y])
    {
        isEnd = false;
        array2D[x, y] = k++;
        visited[x, y] = true;
        --x;
    }

    array2D[x, y] = k;
}
}
void PrintArray (int [,] array2D)
{
    for (int i = 0; i < array2D. GetLength (0) ; i++)
    {
        for (int j = 0; j < array2D. GetLength (1); j++)
        {
            Console.Write($"{array2D[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("rows = ");
int rows = int. Parse(Console. ReadLine() !);
Console.Write("columns = ");
int columns = int. Parse (Console. ReadLine() !);
int[,] myArray = GetArray2D (rows, columns) ;
FillArraySpirally (myArray);
PrintArray (myArray);