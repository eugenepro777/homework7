/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


Console.Write("Введите количество строк:\t");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:\t");
int numberColumn = Convert.ToInt32(Console.ReadLine());
int[,] initialMatrix = new int[numberRow, numberColumn];

FillMatrix(initialMatrix);
PrintMatrix(initialMatrix);
Console.WriteLine();

var sumColumns = FindSumColumn(initialMatrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(FindArithmeticMean(numberRow, numberColumn));

double[] FindArithmeticMean(int row, int column)
{

    double[] averageValue = new double[column];
    for (int i = 0; i < column; i++)
    {
        averageValue[i] = sumColumns[i] / row;
    }
    return averageValue;
}

double[] FindSumColumn(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] sumColumn = new double[columns];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sumColumn[i] += matrix[j, i];
        }
    }
    return sumColumn;
}



void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.WriteLine($"{Math.Round(arr[i], 1)}.");
        }
        else
        {
            Console.Write($"{Math.Round(arr[i], 1)}; ");
        }
    }
}


void FillMatrix(int[,] itemsMatrix)
{
    var item = new Random();
    int rangeSize = 10;
    int lowerLimit = 1;
    for (int i = 0; i < itemsMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < itemsMatrix.GetLength(1); j++)
        {
            itemsMatrix[i, j] = item.Next(lowerLimit, rangeSize);
        }
    }
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

// double[] FindSumRow(int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     double[] sumRow = new double[rows];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             sumRow[i] += matrix[i, j];
//         }
//     }
//     return sumRow;
// }

// PrintArray(FindSumRow(initialMatrix));