// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// решение 2:

bool ExitFromCycle(string value)
{
    if(value == "q") return false;
    int num = Convert.ToInt32(value);
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    if(sum % 2 == 0) return false;
    return true;
}

void RequestingNumber(string value)
{
while(ExitFromCycle(value) == true)
{
    System.Console.WriteLine("Input integer number or q for exit: ");
    value = Console.ReadLine();
}
System.Console.WriteLine("Exit from cycle");
}

System.Console.WriteLine("Input integer number or q for exit: ");
string value = Console.ReadLine();
// RequestingNumber(value);



// // Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // решение 1 - работает:
int[] CreateRandomArray(int size, int min, int max) 
{
    int[] array = new int[size];
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1); 
    }
    return array; 
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int CountEvenNumber(int[] array) // подсчет четных чисел в массиве
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

System.Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, 100, 999);
PrintArray(myArray);

System.Console.WriteLine(CountEvenNumber(myArray));


// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// алгоритм есть
//решение 1 - работает
int[] CreateRandomArray(int size, int min, int max) 
{
    int[] array = new int[size];
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1); 
    }
    return array; 
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);

int[] tempArray(int[] array)
{
    int[] tempArray = new int[array.Length];
    int temp = 0;
    for(int i = 0, count = 1; i < array.Length/2; i++, count++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return tempArray;
}

tempArray(myArray);
PrintArray(myArray);



