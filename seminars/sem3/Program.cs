// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// Создаем метод, который задаст массив и заполит его рандомными значениями. 
//Он должен принять *желаемый размер массива* и *принять диапазон чисел*, в котором будут генерироваться значения.
//Вернет он заданный массив нужного размера.

int[] CreateRandomArray(int size, int min, int max) // int[] говорит о том, что метод будет возвращать массив, а не просто целое число
{
    int[] array = new int[size];
    Random random = new Random(); //для того, чтобы в цикле рандомом воспользоваться, создаем объект этого класса
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1); //у созданного объекта класса random вызываем метод Next, который возвращает рандомное значение в промежутке min и max (max не включительно, поэтому +1)
    }
    return array; //возвращаем созданный массив рандомных чисел
}

void PrintArray(int[] array) // метод для вывода целочисленного массива
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine(); //чтобы был разрыв между массивами, если мы вызовем этот метод 2 раза подряд
}

// // нужно написать метод, который принимает массив и какое-то искомое число и определяет есть данное число в массиве или нет:
// bool SearchNum(int[] array, int num)
// {
//     for(int i = 0; i <array.Length; i++)
//     {
//         if(array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// System.Console.WriteLine("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// //System.Console.WriteLine(myArray); - метод writeline не предназначен для вывода целочисленного массива, 
// //поэтому нам нужно написать самим метод, который выведет массив - Написали метод PrintArray выше
// PrintArray(myArray);

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SearchNum(myArray, num));

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// // [1 -5 6]
// // => [-1 5 -6]


// int[] CreateRandomArray(int size, int min, int max) 
// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1); 
//     }
//     return array; 
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] ChancheArray(int[] array) // метод, который изменяет числа в массиве отрицат на положит, положит на отрицат
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1; // array[i] = array[i] * -1
//     }
//     return array;
// }

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// myArray = ChancheArray(myArray);
// PrintArray(myArray);

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]

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

int[] MultiplicationPairArray(int[] array) //создать массив с произведением пар чисел по задаче
{
    int[] newArray = new int[array.Length/2];
    for(int i = 0; i < newArray.Length; i++) //почему не i <= newArray.Length
    {
        newArray[i] = array[i] * array[array.Length -1 - i];
    }
    return newArray;
}

PrintArray(MultiplicationPairArray(myArray));

//дз про отрезок [0,100]- пишем метод, который будет перебирать полностью этот массив и искать элементы в нужном диапазоне (добавить счетчик)
// кол во четных чисел в массиве - 
//разница между мин и макс - 