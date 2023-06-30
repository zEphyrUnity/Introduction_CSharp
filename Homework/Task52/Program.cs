// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого 
// столбца: 4,6; 5,6; 3,6; 3

const int ROW = 3;
const int COL = 4;
const int MIN = 1;
const int MAX = 9;

int[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);

Console.Clear();
PrintMatrix(matrix);

double[] columnAverage = ColumnAverage(matrix);
Console.WriteLine($"{String.Join("; ", columnAverage.Select(value => Math.Round(value, 1)))}");

double[] ColumnAverage(int[,] matrix)
{
    double[] columnAverage = new double[matrix.GetLength(1)];
    int sum = 0;

    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        columnAverage[i] = (sum * 1.0) / matrix.GetLength(0);
        sum = 0;
    }

    return columnAverage;
}

int[,] GetRandomMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random random = new Random();

    for(int i = 0; i < row; i++)
        for(int j = 0; j < col; j++)
            matrix[i, j] = random.Next(min, max + 1);

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}