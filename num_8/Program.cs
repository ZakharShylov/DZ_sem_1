// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число N  ");
int N = int.Parse(Console.ReadLine()!);

int num = 1;

while (num < N)
{
    num++;
    if (num % 2 != 0)
    {

    }
    else Console.Write($"{num}\n");
}

