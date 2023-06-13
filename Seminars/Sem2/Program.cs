// int FindSum(int num1, int num2)
// {
//     int sum = num1 + num2;
//     return sum;
// }

// int x = 5;
// int y = 6;

// // int result = FindSum (x, y);
// // System.Console.WriteLine(result);
// System.Console.WriteLine(FindSum(x, y));

//Task 1
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// void CheckEven(int num1, int num2)
// {
//     if(num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"Число {num2} кратно числу {num1}");
//     }
//     else
//     {
//         System.Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток от деления -> {num1 % num2}");
//     }
// }

// System.Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckEven(num1, num2);

//Task2
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// bool CheckEven (int num)
// {
//     if(num % 7 == 0 && num % 23 == 0) return true;
//     else return false;
// }
// System.Console.Write("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckEven(num));


//Самостоятельное решение
//Task 1
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
//
//Task 2
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


// void CheckEven (int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     System.Console.WriteLine(ed + sot * 10);
// }
// System.Console.Write("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckEven(num);


// void ques (int num1, int num2)
// {
//     if (num2 == num1 * num1)
//     {
//         System.Console.WriteLine($"Число {num2} является квадратом числа {num1}");
//     }
//      else if (num1 == num2 * num2)
//     {
//         System.Console.WriteLine($"Число {num1} является квадратом числа {num2}");
//     }
//     else
//     {
//         System.Console.WriteLine("Не является квадратом");
//     }
// }

// System.Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// ques(num1,num2);
