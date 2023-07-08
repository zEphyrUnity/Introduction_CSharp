// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
const int ROW = 5;
const int COL = 5;
const int MIN = 1;
const int MAX = 5;

int[,] matrix1 = GetRandomMatrix(ROW, COL, MIN, MAX);
int[,] matrix2 = GetRandomMatrix(ROW, COL, MIN, MAX);

PrintMatrix(matrix1);
Console.WriteLine();

PrintMatrix(matrix2);
Console.WriteLine();

int[,] multiMatrix = SquareMatrixMultiplication(matrix1, matrix2);
PrintMatrix(multiMatrix);


int[,] SquareMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix2.GetLength(0), matrix2.GetLength(0)];
    
        for(int i = 0; i < matrix1.GetLength(0); i++)
            for(int j = 0; j < matrix1.GetLength(0); j++)
                for(int k = 0; k < matrix1.GetLength(0); k++)
                    result[i, j] += matrix1[i, k] * matrix2[k, j];

    return result;
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
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}