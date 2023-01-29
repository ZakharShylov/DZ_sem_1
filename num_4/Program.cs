// Напишите программу, котоз этих чирая принимает на вход три числа и выдаёт максимальное исел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите число c ");
int c = int.Parse(Console.ReadLine()!);

if (a > b)
{
    if (a > c )
    {
        Console.WriteLine($"Максильное число: {a}");
    }
    else 
    {
        Console.WriteLine($"Максильманое число: {b}");
    }
}

else if (b > c)
{
    Console.WriteLine($"Максимальное число: {b}");
}
else 
{
    Console.WriteLine($"Максимальное число: {c} ");
}
