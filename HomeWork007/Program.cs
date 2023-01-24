/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
*/

/*
double[,] CreateRandom2dArray()
{
  Console.Write("Input a number of rows(m): ");
  int m = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns(n): ");
  int n = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());

  double[,] array = new double[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 1);
    }
  }
  return array;
}
void Show2dArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}
double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int [,] CreateRandom2dArray()
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());
    
  int[,] array = new int[rows, columns];
  for(int i = 0; i < rows; i++)
    for(int j = 0; j < columns; j++)
      array[i,j] = new Random().Next(minValue, maxValue + 1);
  return array;
}
void Show2dArray(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

void GetElement(int[,] array, int m, int n)
{
  if(m <= array.GetLength(0) && n <= array.GetLength(1)) 
    Console.WriteLine($"Element value: {array[m, n]}");
  else Console.WriteLine("No element this index");
} 


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.Write("Input element index of rows: ");
int myRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input element index of columns: ");
int myColumns = Convert.ToInt32(Console.ReadLine());
GetElement(myArray, myRows, myColumns);
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] GetArithmeticMean(int[,] array)
{
  double[] result = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
      for(int i = 0; i < array.GetLength(0); i++)
        result[j] += array[i,j];
      result[j] = result[j] / array.GetLength(0);
    }
  return result;
}

void ShowArithmeticMean(double[] mean)
{
    for(int i = 0; i < mean.Length; i++)
        Console.Write(mean[i] + " ");
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] myArithmeticMean = GetArithmeticMean(myArray);
Console.WriteLine("Arithmetic mean each column: ");
ShowArithmeticMean(myArithmeticMean);
