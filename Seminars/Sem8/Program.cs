// Задача на замену чисел в строке, меняются местами

int [,] Create2DArray (int rows, int columns, int minValue, int maxValue) //Создание 2 мерного массива
{
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2DArray(int[,] array) //Выводит 2 мерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// int[,] ChangeRows(int[,] array, int row1, int row2 )
// {
//     if (row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
//     {
//         System.Console.WriteLine($"Rows not find");
//         return array;
//     }
//     else
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array [row1, j];
//             array [row1, j] = array [row2, j];
//             array [row2, j] = temp;
        
//         }
//     return array;
// }
System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input array minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input array maximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number row1 to change: ");
// int row1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number row2 to change: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
// Print2DArray(ChangeRows(myArray, row1, row2 ));


//Задайте двумерный массив, напишите программу которая меняет строки и столбцы

// int[,] RowsToColumns(int [,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1)) //Сравнение сторон массива
//     {
//         System.Console.WriteLine("Not kvad massive");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i+1; j < array.GetLength(1); j++)
//             {
//             int temp = array [i, j];
//             array [i, j] = array [j, i];
//             array [j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// Print2DArray(RowsToColumns(myArray));

// Задача Написать программу, удалить\занулить строку и столбец в котором находится наименьший элемент массива

int [,] MinValue ( int [,] array)
{
    int minI = 0;
    int minJ = 0;
    int minNum = array [0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [ i, j] <= minNum)
            {
                minValue = array [i , j];
                minI = i;
                minJ = j;
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        array [i , minJ] = 0;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [minI, j] = 0;
    }
    return array;
}

Print2DArray(MinValue(myArray));