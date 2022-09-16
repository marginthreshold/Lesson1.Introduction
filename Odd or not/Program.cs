//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

using static System.Console;

Clear();

WriteLine("Введите число:");
int number=Math.Abs(Convert.ToInt32(ReadLine()));

string result = "Число четное";
if (number%2==1) result = "Числое нечетное";

WriteLine(result);