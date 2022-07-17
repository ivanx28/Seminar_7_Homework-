// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillArray(int x, int y)
{
   double[,] arbitraryArray = new double[x, y];
   for(int i = 0; i < arbitraryArray.GetLength(0); i++)
   {
      for (int j = 0; j < arbitraryArray.GetLength(1); j++)
      {
         arbitraryArray[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
      }
   }
   return arbitraryArray;
}

void PrintArray (double[,] arbitraryArray)
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

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(m, n);
PrintArray(array);