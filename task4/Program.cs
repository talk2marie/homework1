﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое число");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"Max number is:{n1}");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"Max number is:{n2}");
}
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"Max number is:{n3}");
}