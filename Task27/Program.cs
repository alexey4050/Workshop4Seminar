// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Задача 27. ");
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int advance = 0;
int sum = 0;
while (number > 0)
    {
    advance = number % 10;
    sum = sum + advance;
    number = number / 10;
    }
    Console.WriteLine($"Сумма всех цифр числа = {sum}");
