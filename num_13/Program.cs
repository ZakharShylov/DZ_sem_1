// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();

Console.Write("Введите число ");

int num = int.Parse(Console.ReadLine()!);
 int res ;

  if (num >= 10000 )
{
     res = num / 100 % 10;
     Console.WriteLine($"Третья цифра данного числа = {res}");
} 
  else   if ( num > 99)
 { 
    res = num / 10 % 10;
      Console.WriteLine($"Третья цифра данного числа = {res}");
}
else 
{
    Console.WriteLine($"Третьей цифры нет ");
}