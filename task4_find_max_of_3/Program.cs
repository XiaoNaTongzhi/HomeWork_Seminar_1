/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел */

Console.Write("Введи первое число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введи второе число: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введи третье число: ");
double c = double.Parse(Console.ReadLine());

double max = a;

if (b > max)
{
max = b;
}

if (c > max)
{
max = c;
}

Console.Write($"Максимальным из чисел {a}, {b} и {c} будет число {max}");