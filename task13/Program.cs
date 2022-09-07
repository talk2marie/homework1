﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int digit_1 = digit;
if (digit > -100 && digit < 100) Console.WriteLine("Третьей цифры нет");
else
{
    while (digit > 999 || digit < -999)
        digit /= 10;
    if (digit < 0 && digit > -999) digit *= (-1);
    digit = digit % 10;
    Console.WriteLine($"{digit_1} -> {digit}");
}
