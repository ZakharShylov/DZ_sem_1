// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();

Console.Write("Введите пятизначное число ");
int num1 = int.Parse(Console.ReadLine()!);
int temp = num1;
int num2 = 0;

while ( temp !=0)
{
    num2 = num2 * 10 + temp % 10;
    temp /= 10 ;
}
if (num1 == num2) 
{
    Console.WriteLine($"Да");
}
else 
{
    Console.WriteLine($"Нет");
}
