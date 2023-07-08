// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

const int ROW = 4;
const int COL = 3;
const int MIN = 1;
const int MAX = 9;

int[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);
PrintMatrix(matrix);
Console.WriteLine();

int minRow = FindMinRow(matrix);
Console.WriteLine(minRow);

int FindMinRow(int[,] matrix) 
{
    int[] rowSum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            rowSum[i] += matrix[i, j];

    int position = 0;
    int min = rowSum[0];

    for(int i = 1; i < rowSum.Length; i++)
        if(min > rowSum[i]) { min = rowSum[i]; position = i;}

    return position + 1;
}

int[,] GetRandomMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random random = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            matrix[i, j] = random.Next(min, max + 1);

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
            
        Console.WriteLine();
    }
}
