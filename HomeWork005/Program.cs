/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
int[] CreateArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue);
  return array;
}
void ShowArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
  Console.WriteLine();
}

int PositiveNumbers(int[] array)
{
  int count = 0;
  for(int i = 0; i < array.Length; i++)
    if(array[i] % 2 == 0) count++;
  return count;
}

Console.WriteLine("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;
int[] array = CreateArray(a, min, max);
ShowArray(array);
Console.WriteLine($"Количество четных чисел в массиве = {PositiveNumbers(array)}");
*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int SumOddNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
    for (int i = 0; i < randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);
      Console.Write(randomNumbers[i] + " ");
      if (i % 2 != 0)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

Console.Write($"Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int randomNumbers =  SumOddNumbers(numberElements, 1, 10);
Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");
*/

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] RandomDoubleArray(int size, int minValue, int maxValue)
{
  double[] array = new double[size];
  for(int i = 0; i < size; i++)
    array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
  return array;
}
void ShowArray(double[] array)
{
  for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);
  Console.WriteLine();
}
double GetDifference(double[] array)
{
  double min = array[0];
  double max = array[0];
  for(int i = 1; i < array.Length; i++)
  {
    if(array[i] < min) min = array[i];
    if(array[i] > max) max = array[i];
  }
  double result = Math.Round(max - min, 2);
  return result;
}
Console.WriteLine("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный предел элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный предел элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] array = RandomDoubleArray(m, min, max);
ShowArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {GetDifference(array)}");
