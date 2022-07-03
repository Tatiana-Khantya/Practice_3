﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"|Куб числа {i,4}  =  |{i * i * i,4}|");
}
}
else Console.WriteLine($"Число {num} отрицательное");