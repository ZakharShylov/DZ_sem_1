// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите номер дня недели ");
int num = int.Parse(Console.ReadLine()!);
 
 while ( num < 1 || num >7 )
 {
     Console.WriteLine($"Введите число от 1 до 7:  ");
     num = int.Parse(Console.ReadLine()!);
 }
 if ( num == 6 || num == 7 )
 {
    Console.WriteLine($"Выходной ");
 }
 else 
 {
    Console.WriteLine($"Будний день ");
 }
