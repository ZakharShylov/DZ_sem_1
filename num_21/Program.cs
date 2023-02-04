// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату точки Xa: ");
double Xa = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координату точки Ya: ");
double Ya = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координату точки Za: ");
double Za = Convert.ToDouble(Console.ReadLine()!);


Console.Write("Введите координату точки Xb: ");
double Xb = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координату точки Yb: ");
double Yb = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координату точки Zb: ");
double Zb = Convert.ToDouble(Console.ReadLine()!);

double x = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));
 Console.WriteLine($"Расстояние между двумя точками в пространстве равно {x}");
