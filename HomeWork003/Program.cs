// Домашнее задание по Семинар 3

/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool Palindrom(int number)
{
  if (number < 0 || (number % 10 == 0 && number != 0)) return false;

  int revers = 0;
  while (number > revers)
  {
    revers = revers * 10 + number % 10;
    number = number / 10;
  }
  return number == revers || number == revers / 10;
}

Console.Write("Input any number: ");
int poliNum = Convert.ToInt32(Console.ReadLine());
if (Palindrom(poliNum))
{
  Console.WriteLine("Это число является палиндромом");
}
else
{
  Console.WriteLine("Это число НЕ является палиндромом");
}

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
double GetCutLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
  return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}
Console.Write("Input x1 dot A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1 dot A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1 dot A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2 dot B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2 dot B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2 dot B: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double cutLength = Math.Round(GetCutLength(x1, y1, z1, x2, y2, z2), 2);
Console.WriteLine($"Длина отрезка {cutLength}");
*/

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void GetTableCube(int number)
{
  int n = 1;
  while(n <= number)
  {
    Console.Write(Math.Pow(n, 3) + " ");
    n++;
  }
}

Console.Write("Input any number: ");
int numCub = Convert.ToInt32(Console.ReadLine());
GetTableCube(numCub);
*/