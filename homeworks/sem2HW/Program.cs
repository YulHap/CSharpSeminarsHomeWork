// // Задача 1. 
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Решение 1 - работает

bool Multiple(int n) // проверка на кратность 7 и 23
{
    if(n % 7==0  && n % 23==0)
    {
        return true;
    }
    return false;
}

void checkMultiple (int num)
{
    if (Multiple(num))
    {
        System.Console.WriteLine("Число " + num + " кратно 7 и 23");
    }
    else 
    {
        System.Console.WriteLine("Число " + num + " не кратно 7 и 23");
    }
}

System.Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
checkMultiple(a);



// Задача 2. 
// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X != 0 и Y != 0 
// и выдает номер координатной четверти плоскости, в которой находится эта точка.

// Решение 1 - работает
void quarter(int x, int y)
{
    if(x > 0 && y > 0)
    {
        System.Console.WriteLine("quarter I");
    }
    if(x < 0 && y > 0)
    {
        System.Console.WriteLine("quarter II");
    }
    if(x < 0 && y < 0)
    {
        System.Console.WriteLine("quarter III");
    }
    if(x > 0 && y < 0)
    {
        System.Console.WriteLine("quarter IV");
    }
    if(x==0 || y == 0)
    {
        System.Console.WriteLine("error");
    }
}
System.Console.WriteLine("Input coordinate X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input coordinate Y: ");
int y = Convert.ToInt32(Console.ReadLine());
quarter(x, y);

// Решение 2 - работает

bool coordinatesNotZero(int x, int y)
{
    if(x != 0 && y != 0)
    {
        return true;
    }
    return false;
}

void quarter(int x, int y)
{
    if(coordinatesNotZero(x, y))
    {
        if(x > 0 && y > 0)
        {
            System.Console.WriteLine("quarter I");
        }
        if(x < 0 && y > 0)
        {
            System.Console.WriteLine("quarter II");
        }
        if(x < 0 && y < 0)
        {
            System.Console.WriteLine("quarter III");
        }
        if(x > 0 && y < 0)
        {
            System.Console.WriteLine("quarter IV");
        }
    }
    else
    {
        System.Console.WriteLine("error");
    }
}

System.Console.WriteLine("Input coordinate X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input coordinate Y: ");
int y = Convert.ToInt32(Console.ReadLine());
quarter(x, y);

// Задача 3. 
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Решение 1 - работает

int maxTwoDigitNumber(int num)
{
    int dec = num / 10;
    int ed = num % 10;
    if(dec > ed)
    {
        return dec;
    }
    return ed;
}

int DigitsNumber (int c)
{
    if(c >= 10 && c <= 99)
    {
        return (maxTwoDigitNumber(c));
    }
    else
    {
        System.Console.WriteLine("Number not two-digit");
        return 0;
    }
}

System.Console.WriteLine("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DigitsNumber(a));

// Задача 4. 
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// решение 1 - работает, но цифры записаны в обратном порядке

void digitWriteN (int n)
{
    int a = 0;
while(n > 0)
{
    a = n % 10;
    Console.Write(a + ",");
    n = n / 10;
}
}

System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine()); // 3657

// digitWriteN (num);

