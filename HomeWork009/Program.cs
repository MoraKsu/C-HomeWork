/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
void PrintNumber(int n)
{
  Console.Write(n + " ");
  if (n > 1) PrintNumber(n - 1);
}

Console.Write("Input the number N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumber(n);
*/

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int sum = 0;

void GetSumNum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Sum of elements from M to N = {sum} ");
    return;
  }
  GetSumNum(m, n - 1, sum);
}

Console.Write("Input the number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number N: ");
int n = Convert.ToInt32(Console.ReadLine());
GetSumNum(m, n, sum);
*/

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int FunctionAck(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAck(m - 1, 1);
  else return FunctionAck(m - 1, FunctionAck(m, n - 1));
}

Console.Write("Input the number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int ackerman = FunctionAck(m, n);
Console.Write($"A({m},{n}) = {ackerman} ");