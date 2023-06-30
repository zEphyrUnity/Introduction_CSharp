// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

const int M = 3;
const int N = 4;

Console.Clear();
int[,] array2D = GetArray2D(M, N);
PrintArray2D(array2D);


int[,] GetArray2D(int m, int n)
{
    int[,] array2D = new int[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array2D[i, j] = i + j;
        }
    }

    return array2D;
}

void PrintArray2D(int[,] array2D)
{
    for(int i = 0; i < array2D.GetLength(0); i++)
    {
        for(int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}