// Задача 49: Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты.
// Например, изначально массив

//  выглядел вот так:       Новый массив будет выглядеть
//                          вот так:

// 1 4 7 2                  1 4 7 2
// 5 9 2 3                  5 81 2 9
// 8 4 2 4                  8 4 2 4 

const int M = 3;
const int N = 4;

Console.Clear();
int[,] array2D = GetRandomArray2D(M, N);

PrintArray2D(array2D);
MagicArray2D(array2D);

Console.WriteLine();
PrintArray2D(array2D);

void MagicArray2D(int[,] array2D)
{
    for(int i = 1; i < array2D.GetLength(0); i += 2)
        for(int j = 1; j < array2D.GetLength(1); j += 2)
                array2D[i, j] *= array2D[i, j];
}

int[,] GetRandomArray2D(int m, int n)
{
    int[,] array2D = new int[m, n];
    Random random = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array2D[i, j] = random.Next(2, 10);
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