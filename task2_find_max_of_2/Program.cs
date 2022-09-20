/* Задача 2: Напишите программу, которая на вход принимает два числа 
и выдаёт, какое большее, а какое меньшее.*/

Console.Write("Введи первое число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введи второе число: ");
double b = double.Parse(Console.ReadLine());

if (a == b) 
{
Console.Write(a);
Console.Write(" = ");
Console.Write(b);
}
else
{
if (a > b) 
{
Console.Write(a);
Console.Write(" > ");
Console.Write(b);
}
else 
{
Console.Write(a);
Console.Write(" < ");
Console.Write(b);
}
}