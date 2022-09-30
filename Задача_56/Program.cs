// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] numbers = new int[4, 6];
Print2DArray(Fill2DArray(numbers));
Console.WriteLine();

int[, ] Fill2DArray(int[, ] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
    return numbers;
}

void Print2DArray (int[, ] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++) 
    {
        for (int j = 0; j < numbers.GetLength(1); j++) 
        {
            Console.Write ($"{numbers[i, j],3} ");
        }
        Console.WriteLine ();
    }
}

int minSumLine = 0;
int sumLine = SumLineElements(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(numbers, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

int SumLineElements(int[,] numbers, int i)
{
  int sumLine = numbers[i,0];
  for (int j = 1; j < numbers.GetLength(1); j++)
  {
    sumLine += numbers[i,j];
  }
  return sumLine;
}

Console.WriteLine($"Наименьшая сумма элементов ({sumLine}) в строке № {minSumLine+1}.");