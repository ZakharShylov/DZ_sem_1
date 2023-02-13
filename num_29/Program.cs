// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] getArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] =new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] inArray)
{
    for(int i = 0; i < inArray.Length - 1; i++ )
    Console.Write($"{inArray[i]}, ");
}
int[] array = getArray(12, 6 , 21);
PrintArray(array);