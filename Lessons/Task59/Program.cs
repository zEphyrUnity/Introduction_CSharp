// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

const int ROW = 4;
const int COL = 5;
const int MIN = 1;
const int MAX = 9;

int[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);
PrintMatrix(matrix);
Console.WriteLine();

var cortage = MatrixMinPosition(matrix);
Console.WriteLine($"row:{cortage.row + 1} col:{cortage.col + 1} min:{cortage.min}\n");

int[,] reducedMatrix = MatrixCutMinElementLines(matrix, cortage.row, cortage.col);
PrintMatrix(reducedMatrix);


int[,] MatrixCutMinElementLines(int[,] matrix, int minElementRow, int minElementCol)
{
    int[,] reducedMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int row = 0;
    int col = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i != minElementRow)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if(j != minElementCol)
                {
                    reducedMatrix[row, col] = matrix[i, j];
                    col++;
                }
            }   

            col = 0;    
            row++;
        }
    }

    return reducedMatrix;
}

(int row, int col, int min) MatrixMinPosition(int[,] matrix)
{
    int min = matrix[0, 0];
    int row = 0;
    int col = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < min) 
            {
                min = matrix[i, j];
                row = i;
                col = j;
            }
        }
    }

    return (row, col, min);
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