/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/
int[,] matrix = new int[5, 3];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = new Random().Next(1, 100);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int minRowSum = int.MaxValue, indexMinRow = 0;

for (int i = 0; i < 5; i++)
{
    int rowSum = 0;
    for (int j = 0; j < 3; j++)
        rowSum += matrix[i, j];

    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}
Console.WriteLine("Row with the smallest sum of elements: " + (indexMinRow) + ", sum of the elements: " + (minRowSum));