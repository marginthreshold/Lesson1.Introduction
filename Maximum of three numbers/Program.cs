//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
///22 3 9 -> 22

using static System.Console;
Clear();

WriteLine("Введите первое число:");
int a=Convert.ToInt32(ReadLine());

WriteLine("Введите второе число:");
int b=Convert.ToInt32(ReadLine());

WriteLine("Введите третье число:");
int c=Convert.ToInt32(ReadLine());


if (a==b && b==c)
{
WriteLine($"Числа одинаковы и равны {a}");
}
else
{
int max=Math.Max(a,b);
max=Math.Max(max,c);

WriteLine($"Максимальное из трех чисел равно {max}");
}
