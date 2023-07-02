// Задача 1. Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

// int [,] Create2DArray (int rows, int columns, int minValue, int maxValue) //Создание 2 мерного массива
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array) //Выводит 2 мерный массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// System.Console.WriteLine(FindSumOfMainDiagonal(myArray));

// //  Задача 4. Задайте двумерный массив, найдите сумму элементов на главной диагонали

// int FindSumOfMainDiagonal(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)    
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if( i == j)
//             {
//                 sum += array[i,j];
//             }
//         }
//     }
//     return sum;
// }


// int [,] Create2DArray (int rows, int columns, int minValue, int maxValue) //Создание 2 мерного массива
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array) //Выводит 2 мерный массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] EvenSum(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
//         }
//     }
//     return array;
// }
// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(array);
// Print2DArray(EvenSum(array));


// int [,] Create2DArray (int rows, int columns) //Создание 2 мерного массива
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array) //Выводит 2 мерный массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DArray(rows, columns);
// Print2DArray(array);