﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int NumberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int NumberB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int NumberC = int.Parse(Console.ReadLine()!);

if (NumberA > NumberB)
{
    if (NumberA > NumberC)
    {
        Console.WriteLine("Максимальное число: " + NumberA);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + NumberC);
    }
}

else if (NumberB > NumberC)
{
    Console.WriteLine("Максимальное число: " + NumberB);
}
else
{
    Console.WriteLine("Максимальное число: " + NumberC);
}