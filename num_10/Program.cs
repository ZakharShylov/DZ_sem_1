// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Clear();

Console.Write("Введите трехзначное число ");

int num = int.Parse(Console.ReadLine()!);
 int res ;

  if (num > 99 && num < 1000)
{
     res = num / 10 % 10;
     Console.WriteLine($"Вторая цифра данного числа = {res}");
} 
  else   
 { 
      Console.WriteLine($"Введите трехзначное число ");
}
//  Console.WriteLine($"вторая цифра данного числа = {res}");

// int res = a1 / 10 % 10;

// Console.WriteLine($"Bторая цифра данного числа = {res}");
