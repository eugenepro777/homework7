/* Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("Введите количество строк:\t");
int numberRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:\t");
int numberColumns = Convert.ToInt32(Console.ReadLine());

double[,] initialMatrix = new double[numberRows, numberColumns];
FillMatrix(initialMatrix);
PrintMatrix(initialMatrix);


void FillMatrix(double[,] itemsMatrix)
{
    var item = new Random();
    int rangeSize = 20;
    int upperLimit = 10;
    for (int i = 0; i < itemsMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < itemsMatrix.GetLength(1); j++)
        {
            itemsMatrix[i, j] = item.NextDouble() * rangeSize - upperLimit;
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i, j], 1)}  ");
        }
        Console.WriteLine();
    }
}