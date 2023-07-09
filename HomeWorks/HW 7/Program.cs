// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] Create2DArray (int rows, int columns) 
// {
//     double[,] array = new double[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = Math.Round(new Random().NextDouble(),2) + new Random().Next(0,99);  
//         }
//     }
//     return array;
// }


// void Print2DArray(double[,] array) //Выводит 2 мерный массив
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


// double[,] myArray = Create2DArray(rows, columns);
// Print2DArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int [,] Create2DArray (int rows, int columns, int minValue, int maxValue)
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

// void Print2DArray(int[,] array) 
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

// bool ValidatePosition (int rows, int columns, int userRows, int userColumns)
// {
//     if (userRows > rows)
//     {
//         System.Console.WriteLine($"Rows {userRows} not find");
//         return false; 
        
//     }
//     if (userColumns > columns)
//     {
//         System.Console.WriteLine($"Columns {userColumns} not find ");
//         return false; 
        
//     }
//     return true;
// }

// int FindElement(int userRow, int userColumn, int [,] myArray)
// {
//     int element = myArray[userRow,userColumn];
//     return element;
// }



// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input array minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input array maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number of find rows: ");
// int userRows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number of find columns: ");
// int userColumns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// if(ValidatePosition(rows, columns, userRows, userColumns)) 
// {
// System.Console.WriteLine($"Число на запрашиваемой позиции равно {FindElement(userRows, userColumns, myArray)}");
// }


// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int [,] Create2DArray (int rows, int columns, int minValue, int maxValue)
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

// void Print2DArray(int[,] array) 
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


// double[] FindAverageColumns(int columns, int [,] array)
// {
//     double[] resultArray = new double[columns];
    
//     for (int j = 0; j < array.GetLength(1); j++)
//     {

//         double sum = 0;
        
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum = sum + array[i,j];
//         }
//         resultArray[j] = Math.Round(sum / array.GetLength(0), 2);
//     }

//     return resultArray;
// }

// void PrintArray(double[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//        System.Console.WriteLine($"Average of elements in a column {i + 1} = {array[i]}" + " ");
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
// System.Console.WriteLine();

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// PrintArray(FindAverageColumns(columns, myArray));
