/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
int GetCountPos(int size)
{
  int count = 0;
  for(int i = 0; i < size; i++)
  {
    Console.Write($"Введите число {i + 1}: ");
    int a = Convert.ToInt32(Console.ReadLine());
      if(a > 0) count++;
  }
  return count;
}

Console.Write("Введите количество чисел для проверки: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Количество положительных чисел = " + GetCountPos(size));
*/

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
double CrossPointX(double k1, double b1, double k2, double b2)
{
  double x = (b2 - b1) / (k1 - k2);
  return x;
}

double CrossPointY(double k1, double b1, double x)
{
  double y = k1 * x + b1;
  return y;
}

Console.Write("Введите значение k1 для прямой 1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1 для прямой 1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2 для прямой 2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2 для прямой 2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = CrossPointX(k1, b1, k2, b2);
double y = CrossPointY(k1, b1, x);
Console.WriteLine($"Координаты точки пересечения двух прямых = ({x}; {y})");
*/