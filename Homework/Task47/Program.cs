// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int ROW = 3;
const int COL = 4;
const double MIN = 0.1;
const double MAX = 9.9;

double[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);

Console.Clear();
PrintMatrix(matrix);

double[,] GetRandomMatrix(int row, int col, double min, double max)
{
    double[,] matrix = new double[row, col];
    Random random = new Random();

    for(int i = 0; i < row; i++)
        for(int j = 0; j < col; j++)
            matrix[i, j] = random.NextDouble() * (max - min) + min;

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f1} ");
        } 
        Console.WriteLine();
    }
}