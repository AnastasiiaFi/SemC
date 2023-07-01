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

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length /2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
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
// myArray = ReverseArray(myArray);
// PrintArray(myArray);

//Написать метод который переводит число в двоичную систему исчисления

// string DecimalToBinary(int num)
// {
//     string result = string.Empty;
//     while(num > 0)
//     {
//         result = num % 2 + result; //т.к. строка, то можно поставить получение остатка от деления вперед и цифра встанет в начало
//         num = num / 2;
//     }
//     return (result);
// }
// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Number {num} in binery -> {DecimalToBinary(num)}");

