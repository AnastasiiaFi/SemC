// System.Console.Write("Введите число, квадрат которого вы хотите увидеть -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// int quat = num * num;
// System.Console.WriteLine($"Квадрат числа {num} -> {quat}");


//Task2
// 5 25 - ?
// 25 5 -?

// System.Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;

// if(num1 == quad)
// {
//     System.Console.Write($"Первое число {num1} является квадратом второго числа {num2}");
// }
// else
// {
//      System.Console.Write($"Первое число {num1} не является квадратом второго числа {num2}");
// }

//Task 3 Написать программу, которая принимает число n и выводит последовательность чисел от -n до n

// System.Console.Write("Введите число N -> ");
// int n = Convert.ToInt32(Console.ReadLine());

// int current = n * (-1);

// while (current <= n)
// {
//     System.Console.Write(current + " ");
//     current ++;
// }

//Task 4 Дано 3-х значное число, нужно вывести последнюю цифру этого числа

// System.Console.Write("Введите трехзначное число -> ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)
// {
//     System.Console.WriteLine(num % 10);
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не трехзначное число");
// }