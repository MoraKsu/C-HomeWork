// Домашнее задание по Семинар 2

/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
int SecondNumber(int number)
{
  int result = number / 10 % 10;
  return result;
}

Console.Write("Введите трёхзначное число: ");
int yourNumber = Convert.ToInt32(Console.ReadLine());
if (yourNumber > 1000 || yourNumber < 100)
{
  Console.WriteLine("Число не является трехзначным");
}
else
{
  Console.WriteLine("Вторая цифра этого числа: " + SecondNumber(yourNumber));
}
*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
int ThirdNumber(int number)
{
  while (number > 1000)
  {
    number = number / 10;
  }
  number = number % 10;
  return number;
}

Console.Write("Введите любое число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
if (anyNumber < 100)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  Console.WriteLine("Третья цифра этого числа: " + ThirdNumber(anyNumber));
}
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

bool DayWeek(int day)
{
  if (day == 6 || day == 7) return true;
  else return false;
}

Console.Write("Введите число, обозначающее день недели: ");
int yourDay = Convert.ToInt32(Console.ReadLine());
if (yourDay > 7)
  {
    Console.WriteLine("В неделе 7 дней, напиши число от 1 до 7");
  }
Console.Write("Введите число, обозначающее день недели: ");
yourDay = Convert.ToInt32(Console.ReadLine());
if (DayWeek(yourDay))
{
  Console.WriteLine("Этот день недели выходной, расслабься и отдыхай");
}
else
{
  Console.WriteLine("Этот день недели НЕ выходной, иди работать");
}