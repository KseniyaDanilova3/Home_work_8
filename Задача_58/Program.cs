// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int height = EnterInt("Введите количество строк в массиве:  ");
int width  = EnterInt("Введите количество стобцов в массиве: ");

Console.WriteLine($"Первая матрица:");
int[ , ] matrix1 = new int[height, width];
Print2DArray(Fill2DArray(matrix1));
Console.WriteLine();
Console.WriteLine($"Вторая матрица:");
int[ , ] matrix2 = new int[height, width];
Print2DArray(Fill2DArray(matrix2));
Console.WriteLine();
int[,] newMatrixResults = new int[height, width];
MultiplyMatrix(matrix1, matrix2, newMatrixResults);
Console.WriteLine($"Произведение первой и второй матриц:");
Print2DArray(newMatrixResults);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

int[, ] Fill2DArray(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void Print2DArray (int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write ($"{matrix[i, j],3} ");
        }
        Console.WriteLine ();
    }
}

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] newMatrixResults)
{
    for (int i = 0; i < newMatrixResults.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrixResults.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            sum += matrix1[i,k] * matrix2[k,j];
        }
            newMatrixResults[i,j] = sum;
        }
    }
}