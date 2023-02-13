// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

int Multi(string allo)
{
    Console.Write(allo);
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int SummaChisel(int number)
{
    int res = 0; 

    for (int i = 0; number > 0; i++)
    {
        
        res = res + number % 10 ;
        number = number / 10;
    }
    return res;
}
int number = Multi("Введите число ");
Console.WriteLine($"Сумма всех чисел в цифре {number} равна {SummaChisel(number)}");
 
