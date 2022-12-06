/* Задача 50. Напишите программу, которая на вход принимает
 позиции элемента в двумерном массиве, и возвращает значение этого элемента
  или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

Console.Write("Задайте номер строки искомого числа: ");
int searchRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Задайте номер столбца искомого числа: ");
int searchColumn = Convert.ToInt32(Console.ReadLine()) - 1;

var matrix = FillMatrix(6, 8);
PrintMatrix(matrix);
FindElementMatrix(matrix);

int[,] FillMatrix(int row, int column)
{
    var item = new Random();
    int rangeSize = 10;
    int lowerLimit = 1;
    
    int[,] matrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = item.Next(lowerLimit, rangeSize);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{(matrix[i, j])}  ");
        }
        Console.WriteLine();
    }
}

void FindElementMatrix(int[,] matrix)
{
    if (searchRow < 0 || searchRow > matrix.GetLength(0) -1 
        || searchColumn < 0 || searchRow > matrix.GetLength(1) - 1)
        Console.WriteLine("Такого элемента нет");
    else
        Console.WriteLine($"Это число найдено:\t{matrix[searchRow, searchColumn]}");
}

