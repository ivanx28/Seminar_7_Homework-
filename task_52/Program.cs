// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int x, int y)
{
   int[,] arbitraryArray = new int[x, y];
   for(int i = 0; i < arbitraryArray.GetLength(0); i++)
   {
      for (int j = 0; j < arbitraryArray.GetLength(1); j++)
      {
         arbitraryArray[i,j] = new Random().Next(1, 100);
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

void AverageColumn(int[,] arbitraryArray)
{
   for(int j = 0; j < arbitraryArray.GetLength(1); j++)
   {
      double sum = 0;
      for (int i = 0; i < arbitraryArray.GetLength(0); i++)
      {
         sum += arbitraryArray[i,j];
      }
      double average = Math.Round ( (sum/arbitraryArray.GetLength(1)) , 2);
      Console.WriteLine($"Среднее арифмитическое элементов столбца {j+1} = {average}");   // +1 для удобства просмотра пользователем.
   }
}

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
AverageColumn(array);