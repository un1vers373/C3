using System;
namespace c1
{
    class Program
    {
        static void Main()
        {
        Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Первое число больше второго!");
}
else if (a == b)
{
    Console.WriteLine("Оба числа равны!");
}
else
{
    Console.WriteLine("ой, косяк попробуйте снова!");
}

        }
    }
}