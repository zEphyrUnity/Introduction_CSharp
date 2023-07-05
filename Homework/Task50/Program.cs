// Задача 50: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> такого числа в массиве нет

const int ROW = 3;
const int COL = 4;
const int MIN = 1;
const int MAX = 9;

int[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);

Console.Clear();
Console.Write("Введите номер строки в матрице  -> ");
int row = TakeUserNum();

Console.Write("Введите номер столбца в матрице -> ");
int col = TakeUserNum();

Console.Clear();
PrintMatrix(matrix);

var cortage = GetElementByIndex(matrix, row, col);

if(cortage.Item1) 
    Console.WriteLine($"[{row}, {col}] -> {cortage.Item2}");
else
    Console.WriteLine($"[{row}, {col}] -> такого числа в массиве нет");


(bool, int) GetElementByIndex(int[,] matrix, int row, int col)
{
    if((row > matrix.GetLength(0)) || (col > matrix.GetLength(1))) 
        return(false, 0);

    return(true, matrix[row - 1, col - 1]);
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

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}