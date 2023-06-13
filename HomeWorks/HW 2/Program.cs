//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// void TwoNumber (int num)
// {
//     int des = num % 100 / 10;
//     System.Console.WriteLine(des);
// }
// System.Console.Write("Введите трехзначное число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 999 && num > 99)
// {
//     TwoNumber(num);
// }
// else 
// {
//     System.Console.WriteLine("Не является трезначным числом");
// }

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// int TreeNumber (int num)
// {
//     while (num > 999) //пока число больше трехзначного дели на 10, после того как станет меньше возьми остаток от деления на 10
//     {
//         num /= 10; 
//     }
//     return num % 10;
// }
// System.Console.Write("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99)
// {
//     System.Console.WriteLine(TreeNumber(num));
// }
// else 
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// bool WeekDay (int num)
// {
//     return num >= 6 && num <=7;
// }
// System.Console.Write("Введите число дня недели -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 1 && num < 8)
// {
//     System.Console.WriteLine(WeekDay(num));
// }
// else
// {
//     System.Console.WriteLine("Такого дня недели не существует");
// }