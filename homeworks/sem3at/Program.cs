//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
      Random random = new Random();
      for(int i = 0; i < numbers.Length; i++)
      {
        numbers[i] = random.Next(minRange, maxRange + 1);
      }
      return numbers;
    }
    
    public static void PrintResult(int[] array)
    {
       for(int i = 0; i < array.Length; i++)
       {
         Console.Write(array[i] + ", ");
       }
      Console.WriteLine();
    }

}
