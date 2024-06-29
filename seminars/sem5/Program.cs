
int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        matrix[i, j] = random.Next(min, max + 1);
    }
}
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
         System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    } 
    System.Console.WriteLine();
}


// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4
//
// 4 3 16 3
// 4 3 4 1
// 4 9 25 4


// int[,] EvenToQuad(int[,] matrix) //метод принимает массив, изменяет его и возвращает 
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i % 2 ==0 && j % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//         }
       
//     } 
//     return matrix;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input min of matrix: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input max of matrix: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] matrix = CreateRandomMatrix(rows, columns, min, max);
// PrintMatrix(matrix);
// int[,] resultMatrix = EvenToQuad(matrix);
// PrintMatrix(resultMatrix);

// // Задайте двумерный массив. Найдите сумму элементов,
// // находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4


// int SumOfMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//          if (i == j)
//          {
//             sum += matrix[i, j];
//          }
//         }
//     } 
//     return sum;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input min of matrix: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input max of matrix: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateRandomMatrix(rows, columns, min, max);
// PrintMatrix(matrix);
// System.Console.WriteLine(SumOfMainDiagonal(matrix));

// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4



double[] SrAr(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(0)];
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        result[i] = (double)sum / matrix.GetLength(1);
    } 
    return result;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input min of matrix: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input max of matrix: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateRandomMatrix(rows, columns, min, max);
PrintMatrix(matrix);
PrintArray(SrAr(matrix));

// дз
// 1 - метод принимает массив и позицию элемента и возвращает его значение. 
// 2 - через временную переменную как в перевороте массива. 
// 3 - один метод возвращает массив с суммами по каждой строке, а второй метод их уже сравнивает между собой