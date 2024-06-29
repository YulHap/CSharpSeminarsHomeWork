// Урок 6. Массивы и строки

// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
// решение 1 - работает


// string TwoCharToString(char[,] matrix)
// {
//     string result = string.Empty;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             result += matrix[i, j];
//         }
//     }
//     return result;
// }

// char [,] matrixChar = new char[,] {
//     {'0', 'a', '2', 'b', '3', 'c'},
//     {'s', 't', 'r', 'i', 'n', 'g'}                       
// };

// System.Console.WriteLine(TwoCharToString(matrixChar));


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
//решение 1 - работает

// string str = "Hello World";
// System.Console.WriteLine(str.ToLower());


// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

string str = "abcde";




char[] StringToChars(string str)
{
    char[] result = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        result[i] = str[i];
    }
    return result;
}

void PrintArray(char[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write("'" + array[i] + "' " );
    }
    System.Console.WriteLine("");
}


void ReversString (char[] array)
{
     for(int i = array.Length -1; i >= 0; i--)
    {
        System.Console.Write("'" + array[i] + "' " );
    }
    System.Console.WriteLine("");
}

PrintArray(StringToChars(str));
ReversString (StringToChars(str));



// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.