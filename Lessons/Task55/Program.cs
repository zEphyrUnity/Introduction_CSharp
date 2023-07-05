// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

const int ROW = 2;
const int COL = 5;
const int MIN = 1;
const int MAX = 9;

int[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);
PrintMatrix(matrix);
Console.WriteLine();

int[,] turnedMatrix = TurnMatrix(matrix);
PrintMatrix(turnedMatrix);
Console.WriteLine();


int[,] TurnMatrix(int[,] matrix)
{
    int[,] turnedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            turnedMatrix[j, i] = matrix[i, j];

    return turnedMatrix;
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
