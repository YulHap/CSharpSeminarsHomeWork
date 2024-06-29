﻿void OneToN(int n)
{
    if(n > 0)
    {
        OneToN(n - 1);
        Console.Write(n + " ");
    }
}

OneToN(5);

// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumOfDigits(int num)//456
{
    if(num > 0)
    {
        return num % 10 + SumOfDigits(num / 10);//4
    }
    return 0;
}
System.Console.WriteLine(SumOfDigits(456));

//6 + (5 + (4 + выход из рекурсии) 
// "return 0" просто заглушка. При умножении - "return 1"

// задача
// напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

int Pow(int a, int b)
{
    if(a == 1) return 1;
    if(b == 0) return 1;
    return a * Pow(a, b - 1);
    
}

System.Console.WriteLine(Pow(2, 5));

