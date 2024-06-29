// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Input number: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Quat of " + x + " is " + x * x);*/

// Задание 1. Совместная работа
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

System.Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b * b) //два знака равно! Обратить внимание!
{
    System.Console.WriteLine($"a = {a}, b = {b} -> yes");
}
else
{
    System.Console.WriteLine($"a = {a}, b = {b} -> no");
};


// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

System.Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine()); // если пользователь решит ввести отрицательное число - не работает никак
int start = -n;
while (start <= n)
{
    System.Console.Write(start + " ");
    start++;
};

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

using System.Xml.Serialization;

System.Console.WriteLine("Input three-digit number N: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    int sot = num / 100;
    int ed = num % 10;
    System.Console.WriteLine("sum = " + (sot + ed));
}
else
{
    System.Console.WriteLine("You input not three-digit number");
};