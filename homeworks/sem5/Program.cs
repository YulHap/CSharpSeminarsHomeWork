
// задача 2 - решена, принято! в автотесте пришлось один метод дорасписать, тут у меня код короче вышел
// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + "\t");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }

// int[,] SwapFirstLastRows(int[,] array) // Обмен первой с последней строкой
// {
//   int temp = array[0, 0];
//   for (int i = 0; i == 0; i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       temp = array[i, j];
//       array[i, j] = array[array.GetLength(0) - 1, j];
//       array[array.GetLength(0) - 1, j] = temp;
//     }
//   }
//   return array;
// }

// PrintArray(numbers);
// int[,] resultArray = SwapFirstLastRows(numbers);
// PrintArray(resultArray);

// // задача 3 решена - принято
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };

// /// Вычисление сумм по строкам (на выходе массив с суммами строк)
// int[] SumRows(int[,] array)
// {
//   int[] arrResult = new int[array.GetLength(0)];
//   int sum = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)//1+
//     {
//       sum = sum + array[i, j];
//     }
//   arrResult[i] = sum; 
//   sum = 0;
//   }
//   return arrResult;
// }

// // void PrintArray(int[] array)
// // {
// //   for(int i = 0; i < array.Length; i++)
// //   {
// //     System.Console.Write(array[i] + ", ");
// //   }
// // }


// // // Получение индекса минимального элемента в одномерном массиве
// int MinIndex(int[] array)
// {
//   int min = array[0];
//   int indexMin = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] < min)
//     {
//       min = array[i];
//       indexMin = i;
//     }
//   }
//   return indexMin;
// }

// void PrintResult(int[,] numbers)
// {
//   int[] resultArray = SumRows(numbers);
//   Console.WriteLine(MinIndex(resultArray));
// }

// PrintResult(numbers);

// задача 1
int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int x = 2;
int y = 2;

int FindElementByPosition(int[,] array, int x, int y)
{
        x -= 1;
        y -= 1;
    return array[x, y];
}

// Проверка позиций на вхождение в массив
bool ValidatePosition(int[,] array, int x, int y)
{
    if (x > array.GetLength(0) || y > array.GetLength(1)) return false;
    if (x < 0 || y < 0) return false;
    return true;
}

void PrintResult(int[,] numbers, int x, int y)
{
    if(ValidatePosition(numbers, x, y) == true)
    {
        System.Console.WriteLine(FindElementByPosition(numbers, x, y));
    }
    if(ValidatePosition(numbers, x, y) == false)
    {
        System.Console.WriteLine("Позиции не входят в границы массива");
    }
}

PrintResult(numbers, x, y);