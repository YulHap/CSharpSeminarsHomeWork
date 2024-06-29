// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// решение 1 - работает

void FromMtoN(int m, int n) 
{
    if(m <= n)
    {
        FromMtoN(m, n - 1);
        System.Console.Write(n + ", ");
    }
}

System.Console.WriteLine("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

FromMtoN(m, n);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// решение 1 - работает ().

 Console.Write("Введите неотрицательное число m: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write("Введите неотрицательное число n: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
 
int result = AckermannFunction(m, n); 
Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {result}"); 
 
int AckermannFunction(int m, int n) 
    { 
        if (m == 0) 
            return n + 1; 
        else if (n == 0) 
            return AckermannFunction(m - 1, 1); 
        else 
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1)); 
    } 


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// решение 1 - работает

int [] numbers = {6, 4, 8, -5, 0, 9, -3, 7};
int i = numbers.Length - 1;

void ReverseArray(int[] array, int i)
{
    if(i >= 0)
    {
        System.Console.Write(array[i] + " ");
        ReverseArray(array, i - 1);
    }
}

ReverseArray(numbers, i);