//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuad(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }
//     if (x < 0 && y > 0)
//     {
//         return 2;
//     }
//     if (x < 0 && y < 0)
//     {
//         return 3;
//     }
//     if (x > 0 && y < 0)
//     {
//         return 4;
//     }
//     return 0;
// }

// System.Console.WriteLine("Input X coordinate: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Y coordinate: ");
// int y = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Point with X coordinate ({x}) and Y coordinate ({y}) belongs to {FindQuad(x,y)} quard");

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance (double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2)+ Math.Pow(yb - ya, 2)), 2);
// }

// System.Console.WriteLine("Input X coordinate point a: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Y coordinate point a: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input X coordinate point b: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Y coordinate point b: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between points A and B -> {FindDistance(xa, ya, xb, yb)}");

//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// void FindkQuad (int quad)
// {
//     if (quad == 1)
//     {
//         System.Console.WriteLine($"Диапазон X+, Y+");
//     }
//     else if (quad == 2)
//     {
//         System.Console.WriteLine($"Диапазон X-, Y+");
//     }
//     else if (quad == 3)
//     {
//        System.Console.WriteLine($"Диапазон X-, Y-"); 
//     }
//     else if (quad == 4)
//     {
//        System.Console.WriteLine($"Диапазон X+, Y-"); 
//     }
//     else 
//     {
//        System.Console.WriteLine($"Введены неверные данные"); 
//     }
// }
// System.Console.Write ("Введите номер четверти, для определения диапозонов x и y -> ");
// int quad = Convert.ToInt32 (Console.ReadLine());
// FindkQuad(quad);

// void Square (int N)
// {
//     int num = 1;
//     while (num <= N)
//     {
//         System.Console.WriteLine($"Квадрат числа - {num} -> {num*num}");
//         num++;
//     }
// }
// System.Console.Write ("Введите число N -> ");
// int num = Convert.ToInt32 (Console.ReadLine());
// Square(num);