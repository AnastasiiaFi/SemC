// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void CheckingNumber(int n)
// {
//     int num = n;
//     int res = 0;
//     while (num != 0)
//     {
//         res = res * 10 + num % 10;
//         num = num / 10;
//     }
//     if (res == n)
//     {
//         System.Console.WriteLine($"Число {n} является полиндромом");
//     }
//     else
//     {
//         System.Console.WriteLine($"Число {n} не является полиндромом");
//     }
// }
// System.Console.Write ("Введите число N -> ");
// int num = Convert.ToInt32 (Console.ReadLine());
// CheckingNumber(num);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2)+ Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }

// System.Console.WriteLine("Input X coordinate point a: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Y coordinate point a: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Z coordinate point a: ");
// double za = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input X coordinate point b: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Y coordinate point b: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Z coordinate point b: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between points A and B in 3D -> {FindDistance(xa, ya, za, xb, yb, zb)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void NumCubes (int N)
// {
//     int num = 1;
//     while (num <= N)
//     {
//         System.Console.WriteLine($"Куб числа - {num} -> {num*num*num}");
//         num++;
//     }
// }
// System.Console.Write ("Введите число N -> ");
// int num = Convert.ToInt32 (Console.ReadLine());
// NumCubes(num);