// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(99,999 + 1);
//     }
//     return array;
// }
// int Colvo(int [] array)
// {
//     int Colvo = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if (array[i] % 2 == 0)
//        Colvo++;
//     }
//     return Colvo;
// }
// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array [i]}, ");
//     }
//     System.Console.Write(" ");
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] myArray = CreateRandomArray(size);
// PrintArray (myArray);
// System.Console.WriteLine($"Количество четных чисел в массиве: {Colvo(myArray)}");


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// int SumNePos(int [] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if (i % 2 != 0)
//        sum = sum + array[i];
//     }
//     return sum;
// }
// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array [i]}, ");
//     }
//     System.Console.Write(" ");
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int [] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray (myArray);
// System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumNePos(myArray)}");



// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double [] CreateRandomArray(int size)
// {
//     double[] array = new double [size];
//     var random = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round(random.NextDouble(), 3)+ random.Next(0,99);
//     }
//     return array;
// }
// double Diff (double [] array)
// {
//     double min = array[0];
//     double max = array[0];
//     int i = 1;
//     while (i < array.Length)
//     {
//         if (max < array[i])
//         max = array[i];
//         if (min > array[i])
//         min = array[i];
//         i++;
//     }
//     return Math.Round(max - min, 2);
// }
// void PrintArray (double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array [i]}, ");
//     }
//     System.Console.Write(" ");
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double [] myArray = CreateRandomArray(size);
// PrintArray (myArray);
// System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {Diff(myArray)}");

