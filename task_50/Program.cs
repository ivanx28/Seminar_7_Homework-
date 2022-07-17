// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int x, int y)
{
   int[,] arbitraryArray = new int[x, y];
   for(int i = 0; i < arbitraryArray.GetLength(0); i++)
   {
      for (int j = 0; j < arbitraryArray.GetLength(1); j++)
      {
         arbitraryArray[i,j] = new Random().Next(10, 100);
      }
   }
   return arbitraryArray;
}

void PrintArray (int[,] arbitraryArray)
{
   for(int i = 0; i < arbitraryArray.GetLength(0); i++)
   {
      for (int j = 0; j < arbitraryArray.GetLength(1); j++)
      {
         Console.Write($"| {arbitraryArray[i,j]} |");
      }
      Console.WriteLine();
   }
}

void FindNumber(int[,] arbitraryArray, int num)
{
   int line = -1;
   int column = -1;
   for(int i = 0; i < arbitraryArray.GetLength(0); i++)
   {
      for (int j = 0; j < arbitraryArray.GetLength(1); j++)
      {
         if (num == arbitraryArray[i,j]) 
         {
            line = i;
            column = j;
            Console.WriteLine($"Введённое число {num} есть в заданном массиве и находится в строке {i+1} столбце {j+1}");   // Здесь +1 для удобства пользователя (не считать с 0).
         }
      }
   }
   if (line < 0 && column < 0)
   Console.WriteLine($"Введённое число {num} отсутствует в заданном массиве");
}

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m, n);
PrintArray(array);

Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

FindNumber(array, number);