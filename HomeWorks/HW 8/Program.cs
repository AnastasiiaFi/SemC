// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
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
// OrderArrayLines(myArray);
// Print2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

// int MinSumLine (int [,] array)
// {
//   int[] sumLine = new int[array.GetLength(0)];
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       sumLine[i] += array[i, j];
//     }
//     Console.WriteLine($"Row = {i + 1}, Sum in row = {sumLine[i]}");
//   }
//   int minSum = sumLine[0];
//   int minRow = 1;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     if (sumLine[i] < minSum)
//     {
//       minSum = sumLine[i];
//       minRow = i + 1;
//     }
//   }
//   return minRow;
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
// System.Console.WriteLine($"Minimal sum find in row - {MinSumLine(myArray)}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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


// int[,] MultiplyArray(int[,] firstArray, int[,] secondArray)
// {
//   int newRow, newCol;
//   if (firstArray.GetLength(0) > secondArray.GetLength(0))
//   {
//     newRow = secondArray.GetLength(0);
//   }
//   else
//   {
//     newRow = firstArray.GetLength(0);
//   }
//   if (firstArray.GetLength(1) > secondArray.GetLength(1))
//   {
//     newCol = secondArray.GetLength(1);
//   }
//   else
//   {
//     newCol = firstArray.GetLength(1);
//   }

//   int[,] newArray = new int[newRow, newCol];

//   for (int i = 0; i < newRow; i++)
//   {
//     for (int j = 0; j < newCol; j++)
//     {
//       for (int k = 0; k < newRow; k++)
//       {
//         newArray[i, j] += firstArray[i, k] * secondArray[k, j];
//       }
//     }
//   }
//   return newArray;
// }

// System.Console.WriteLine("Input number of rows for array one: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number of columns for array one: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number of rows for array two: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number of columns for array two: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input array minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input array maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] firstArray = Create2DArray(rows1, columns1, minValue, maxValue);
// int[,] secondArray = Create2DArray(rows2, columns2, minValue, maxValue);
// Console.WriteLine("First Array:");
// Print2DArray(firstArray);
// Console.WriteLine("Second Array:");
// Print2DArray(secondArray);
// Console.WriteLine("Result of matrix multiplication:");
// int[,] newArray = MultiplyArray(firstArray, secondArray);
// Print2DArray(newArray);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

void Create3DArray (int[,,] array3D) 
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}


void Print3DArray(int[,,] array3D) 
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        System.Console.Write($"{array3D[i,j,k]} ({i},{j},{k})");
      }
      System.Console.WriteLine();
    }
    System.Console.WriteLine();
  }
}

System.Console.WriteLine("Input number of rows : ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input number of columns : ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input number of depth : ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[rows,columns,depth];
Create3DArray(array3D);
Print3DArray(array3D);

