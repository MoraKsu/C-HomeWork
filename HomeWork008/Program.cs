// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] NewRowsArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine("Отсортированный массив: ");
Show2dArray(NewRowsArray(myArray));
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int RowMinSum(int[,] array)
{
  int index = 0;
  int result = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
      sum += array[i, j];
    if (i == 0) result = sum;
    else if (sum < result)
    {
      result = sum;
      index = i;
    }
  }
  return index;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int rowIndex = RowMinSum(myArray);
Console.WriteLine($"Наименьшая сумма элементов в строке под индексом: {rowIndex}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


void CreateRandom2dArray()
{
  Console.Write("Enter the number of rows for  array 1: ");
  int rows1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter the number of columns for array 1: ");
  int cols1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minValue1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxValue1 = Convert.ToInt32(Console.ReadLine());
    
  int[,] array1 = new int[rows1, cols1];
  for(int i = 0; i < rows1; i++)
  {
    for(int j = 0; j < cols1; j++)
    {
      array1[i,j] = new Random().Next(minValue1, maxValue1 + 1);
      Console.Write(array1[i,j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();

  Console.Write("Enter the number of rows for  array 2: ");
  int rows2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter the number of columns for array 2: ");
  int cols2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minValue2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxValue2 = Convert.ToInt32(Console.ReadLine());
    
  int[,] array2 = new int[rows2, cols2];
  for(int i = 0; i < rows2; i++)
  {
    for(int j = 0; j < cols2; j++)
    {
      array2[i,j] = new Random().Next(minValue2, maxValue2 + 1);
      Console.Write(array2[i,j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();

  if (cols1 != rows2)
  {
    Console.WriteLine("Error: The number of columns in matrix 1 must be equal to the number of rows in matrix 2.");
  }
  else
  {
    int[,] result = ProductTwoArray(array1, array2);
    Console.WriteLine("Произведение двух матриц: ");
    for (int i = 0; i < rows1; i++)
    {
      for (int j = 0; j < cols2; j++)
      {
        Console.Write(result[i,j] + " ");
      }
      Console.WriteLine();
    }
  }
}

int[,] ProductTwoArray(int[,] arr1, int[,] arr2)
{
  int rows1 = arr1.GetLength(0);
  int cols1 = arr1.GetLength(1);
  int rows2 = arr2.GetLength(0);
  int cols2 = arr2.GetLength(1);

  int[,] product = new int[rows1, cols2];
    for (int i = 0; i < rows1; i++)
    {
      for (int j = 0; j < cols2; j++)
      {
        for (int k = 0; k < cols1; k++)
        {
          product[i, j] += arr1[i, k] * arr2[k, j];
        }
      }
    }
  return product;
}

CreateRandom2dArray();


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
Console.Write("Input a X of 3D matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Y of 3D matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Z of 3D matrix: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[x, y, z];

void CreateRandom3dArray(int[,,] array3D)
{
  int[] array = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int number;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    array[i] = new Random().Next(10, 100);
    number = array[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (array[i] == array[j])
        {
          array[i] = new Random().Next(10, 100);
          j = 0;
          number = array[i];
        }
        number = array[i];
      }
    }
  }
  int count = 0;
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = array[count];
        count++;
      }
    }
  }
}

void Show3dArray(int[,,] array3D)
{
  for(int i = 0; i < array3D.GetLength(0); i++)
  {
    for(int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.WriteLine();
      for (int k = 0; k < array3D.GetLength(2); k++)
        Console.Write($"{array3D[i,j,k]}({i},{j},{k}) ");
    }
  }
  Console.WriteLine();
}

CreateRandom3dArray(array3D);
Show3dArray(array3D);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int[,] SpiralArray()
{
  Console.Write("Input a size array: ");
  int size = Convert.ToInt32(Console.ReadLine());
    
  int[,] array = new int[size, size];

  int num = 1;
  int minRow = 0;
  int maxRow = size-1;
  int minCol = 0;
  int maxCol = size-1;

  while (num <= array.GetLength(0) * array.GetLength(1))
  {
    for (int i = minCol; i <= maxCol; i++)
    {
      array[minCol, i] = num;
      num++;
    }
    minRow++;
    for (int i = minRow; i <= maxRow; i++)
    {
      array[i, maxCol] = num;
      num++;
    }
    maxCol--;
    for (int i = maxCol; i >= minCol; i--)
    {
      array[maxRow, i] = num;
      num++;
    }
    maxRow--;
    for (int i = maxRow; i >= minRow; i--)
    {
      array[i, minCol] = num;
      num++;
    }
    minCol++;
  }
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

int[,] myArray = SpiralArray();
Show2dArray(myArray);
*/

