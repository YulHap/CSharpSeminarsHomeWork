// Методы-функции 

// 1. написание метода начинается с типа данных, который будет возвращаться  
// 2. потом задаем название метода 
// 3. в круглых скобках аргумент-переменная (указывая тип данных), который мы этому методу передаем; их может быть несколько.
// Без аргумента метод работать не будет


int Pow(int n) // Pow - возведение в квадрат?; n - число, которое мы возводим в квадрат. ";" ставить не надо 
{
    return n * n; // что метод должен вернуть. Без знака равно. После слова return метод прекращает работу
}
System.Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Pow(a));

// void - пустота. Выполнятяет строчки кода, но не возвращает вообще никакого значения
void Pow2(int n) // после void никакой тип данных не указывается
{
    System.Console.WriteLine($"Quad of {n} -> {n * n}");
}

System.Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
Pow2(a);

// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

bool IsThreeDigit (int num) //проверяет на 3-значность
{
    if(num > 99 && num < 1000) 
    {
        return true;
    }
    return false;
}

int DeleteSecondDigit(int num)
{
    if(IsThreeDigit(num)) //456
    {
        int ed = num % 10;
        int sot = num / 100;
        return sot * 10 + ed;
    }
    else 
    {
        System.Console.WriteLine("You input not three-digit number");
        return 0;
    }
}

void DeleteSecondDigit(int num)
{
    if(IsThreeDigit(num)) //456
    {
        int ed = num % 10;
        int sot = num / 100;
        System.Console.WriteLine(sot * 10 + ed);
    }
    else 
    {
        System.Console.WriteLine("You input not three-digit number");
    }
}

System.Console.WriteLine("Input three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
DeleteSecondDigit(a); //в void передавать в Console.WriteLine не нужно

// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

bool IsThreeDigit (int num) //проверяет на 3-значность
{
    if(num > 99 && num < 1000) 
    {
        return true;
    }
    return false;
}

void SecondToThirdPower(int num)
{
    if(IsThreeDigit(num)) //456
    {
        int dec = num / 10 % 10;
        int ed = num % 10;
        System.Console.WriteLine(Math.Pow(dec, ed)); // Math.Pow (что возводим в степень, в какую степень возводим) - возведение в степень
    }
    else
    {
        System.Console.WriteLine("You input not three-digit number");
    }
}

System.Console.WriteLine("Input three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
SecondToThirdPower(a);

// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.

bool kratnost (int x, int y) //проверка кратно ли первое число второму
{
    if (x % y == 0)
    {
        return true;
    }
    return false;
}

void kratnostOutput (int x, int y) //указывает кратно ли число и остаток от деления, если не кратно
{
    if (kratnost(x, y))
    {
        System.Console.WriteLine("Первое число кратно второму");
    }
    else
    {
        int a = x % y;
        System.Console.WriteLine("Остаток от деления" + " " + a);
    }
}

System.Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
kratnostOutput (num1, num2);