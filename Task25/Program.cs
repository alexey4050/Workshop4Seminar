﻿// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Задача 25. ");
Console.WriteLine("Введите целое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= numberB; i++)
 {
     result = result * numberA;
 }
Console.WriteLine($"Число A возвести в степень B = {result}");
