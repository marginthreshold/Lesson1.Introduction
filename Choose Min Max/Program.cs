//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

using static System.Console;
Clear();

WriteLine("Введите первое число:");
int a=Convert.ToInt32(ReadLine());

WriteLine("Введите второе число:");
int b=Convert.ToInt32(ReadLine());

if (a==b)
{
WriteLine("Числа равны");
}
else
{
int max=Math.Max(a,b);
int min=Math.Min(a,b);
WriteLine($"Максимальное число равно {max}");
WriteLine($"Минимальное число равно {min}");
}