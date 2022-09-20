// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введи число: ");
int n = int.Parse(Console.ReadLine());

int a = 1;

while (a <= n)
{
    if (a % 2 == 0)
    {
        Console.Write($"{a} ");
    }
     a++;
}
