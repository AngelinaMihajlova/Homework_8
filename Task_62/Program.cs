﻿/*
Задача 62. Заполните спирально массив 4 на 4.
*/

const int N = 4;
int[,] spiralMatrix = new int[N, N];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
    spiralMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(spiralMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}