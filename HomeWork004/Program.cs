/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
int GetNumberPower(int numA, int numB) {
  int number = 1;
  for (int i = 1; i <= numB; i++) {
    number *= numA;
  }
  // Math.Pow(numA, numB);
  return number;
}
Console.Write("Input a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = GetNumberPower(a, b);
Console.WriteLine($"Число {a} в {b} степени = {result}");
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int SumNumbers(int num) {
  int sum = 0;
  while (num > 0) {
    sum += num % 10;
    num /= 10;
  }
  return sum;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(a);
Console.WriteLine($"Сумма цифр в числе {a} = {result}");
*/

/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(int size) {
  int[] array = new int[size];

  for (int i = 0; i < size; i++) {
    Console.Write($"Input element of array index {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  return array;
}

void ShowArray(int[] array) {
  int i = 0;
  Console.Write("[");
  while (i < array.Length) {
    Console.Write(array[i]);
    i++;
    if (i < array.Length) {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
}

Console.Write("Input a size of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(sizeArray);
ShowArray(newArray);