﻿//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели от 1 до 7: ");
int d = Convert.ToInt32(Console.ReadLine());

if (d < 1 || d > 8) Console.Write("Вы ввели недопустимое значение,otne попробуйте ещё раз!");
else if (d == 1) Console.Write("Понедельник не является выходным");
else if (d == 2) Console.Write("Вторник не является выходным");
else if (d == 3) Console.Write("Среда не является выходным");
else if (d == 4) Console.Write("Четверг не является выходным");
else if (d == 5) Console.Write("Пятница не является выходным");
else if (d == 6) Console.Write("Суббота является выходным");
else if (d == 7) Console.Write("Воскресенье является выходным");
