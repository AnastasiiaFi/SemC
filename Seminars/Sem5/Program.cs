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

// void PosNegSum (int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sumPos += array [i];
//         else sumNeg += array [i];
//     }
//     System.Console.WriteLine($" Sum of positive elements -> {sumPos} -------- Sum of negative elements -> {sumNeg}");
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// PosNegSum(myArray);

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

// int [] InvertArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array [i] *= -1;
//     }
//     return array;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray (myArray);
// myArray = InvertArray(myArray);
// PrintArray(myArray);

// int [] CreateArray(int size)
// {
//     System.Console.WriteLine("Введите число массива");
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// bool FindNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array [i] == number) return true;
        
//     }
//     return false;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Find number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray (size);
// if (FindNumber(array, number))
// {
//     System.Console.WriteLine($"{number} найден в массиве");
// }
// else
// {
//     System.Console.WriteLine($"{number} не найден в массиве");
// }


// int [] CreateArray()
// {
//     int[] array = new int[123];
//     for (int i = 0; i < 123; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
//     return array;
// }

// int FindColvo(int[] array, int minValue, int maxValue)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > minValue && array[i] < maxValue)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array [i]}, ");
//     }
//     System.Console.Write(" ");
// }
// System.Console.WriteLine("Input array minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input array maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray();
// PrintArray (array);
// System.Console.WriteLine($"Количество элементов в диапазоне от {minValue} до {maxValue} -> {FindColvo(array,minValue,maxValue)}");