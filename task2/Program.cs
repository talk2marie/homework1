// Напишите программу, которая на вход 
// 1. принимает два числа
// 2. и выдаёт, какое число большее, а какое меньшее.
// 3. вывод результата

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Max number is: {a}");
}
else if (a < b)
{
    Console.WriteLine($"Max number is: {b}");
}
else
{
    Console.WriteLine("Numbers are equal");
}






