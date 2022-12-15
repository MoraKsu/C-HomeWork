// Домашнее задание по Семинар 1

/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Input any first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input any second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if(a > b)
{
  max = a;
  min = b;
}
else
{
  max = b;
  min = a;
}

Console.Write("Число max = ");
Console.WriteLine(max);
Console.Write("Число min = ");
Console.WriteLine(min);
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Input any first numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input any second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input any third number: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a}, {b}, {c}");

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Введите любое число, чтобы проверить является ли оно четным: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
  Console.WriteLine(true);
}
else
{
  Console.WriteLine(false);
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)
{
  if(current % 2 == 0)
  {
    Console.Write(current + " ");
  }
  current++;
}