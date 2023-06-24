//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int FindDegree (int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }

// System.Console.Write ("Введите число A -> ");
// int a = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Введите число B -> ");
// int b = Convert.ToInt32 (Console.ReadLine());
// if (b <= 0)
// {
//     System.Console.WriteLine("Показетель не должен быть меньше нуля");
// }
// else
// {
//     System.Console.WriteLine(FindDegree(a, b)); 
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int FindSum(int a)
// {
//     int sum = 0;
//     while (a > 0)
//     {
//         sum += a % 10;
//         a = a / 10;
//     }
//     return sum;
// }
// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Sum number {a} -> {FindSum(a)}");



//Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int [] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, minValue, maxValue));
