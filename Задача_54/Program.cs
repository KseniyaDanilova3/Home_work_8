// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int height = EnterInt("Введите количество строк в массиве:  ");
int width  = EnterInt("Введите количество стобцов в массиве: ");

int[ , ] numbers = new int[height, width];
Print2DArray(Fill2DArray(numbers));
Console.WriteLine();
Print2DArray(DescendingSort(numbers));



int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

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

int[,] DescendingSort(int[,] numbers)
{    
    for (int i = 0; i < numbers.GetLength(0); i++)
    {

        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            int jMax = j;
            int max = numbers[i, jMax];
            
            for (int k = j + 1; k < numbers.GetLength(1); k++)
            {
                if (numbers[i, k] > max)
                {
                max = numbers[i, k];
                (numbers[i, j], numbers[i, k]) = (numbers[i, k], numbers[i, j]);
                }
            }
        }
    }
    return numbers;
}