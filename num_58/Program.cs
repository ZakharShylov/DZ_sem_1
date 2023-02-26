﻿int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Матрицы невозможно умножить!");
        return matrixC;
    }
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Console.Clear();

Console.Write("Введите размерность MatrixA через запятую: ");
int[] dimensionA = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
int[,] matrixA = GetMatrix(dimensionA[0], dimensionA[1], -9, 9);
Console.Write( "Введите размерность Matrix через запятую: ");

int[] dimensionB = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
int[,] matrixB = GetMatrix(dimensionB[0], dimensionB [1], -9, 9);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);