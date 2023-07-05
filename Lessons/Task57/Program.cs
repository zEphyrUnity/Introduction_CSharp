// Задача 57: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент 
// входных данных.

const int ROW = 5;
const int COL = 5;
const int MIN = 1;
const int MAX = 9;

int[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = MatrixToArray(matrix);
ArraySort(array);

int[,] frequencyDictionary = FrequencyDictionary(array);
PrintMatrix(frequencyDictionary);


int[,] FrequencyDictionary(int[] array)
{
    const int dictionaryColumnSize = 2;
    const int initValue = 1;

    int[,] frequencyDictionary = new int[VariousElementCounter(array), dictionaryColumnSize];
    int reference = array[0];

    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(i == 0)
        {
            frequencyDictionary[j, 0] = array[i];
            frequencyDictionary[j, dictionaryColumnSize - 1] = initValue;
        }
        else if(reference == array[i])
        {
            frequencyDictionary[j, dictionaryColumnSize - 1]++;
        }
        else
        {
            reference = array[i];
            j++;

            frequencyDictionary[j, 0] = array[i];
            frequencyDictionary[j, dictionaryColumnSize - 1] = initValue;
        }
    }

    return frequencyDictionary;
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int counter = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            array[counter] = matrix[i, j];
            counter++;
        }
    }

    return array;
}

void ArraySort(int[] array)
{
    int temp = 0;
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = 0; j < array.Length - 1; j++)
        {
            if(array[j] > array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }            
        }
    }
}

int VariousElementCounter(int[] array)
{
    int reference = array[0];
    int counter = 1;

    for(int i = 0; i < array.Length; i++)
    {
        if(reference != array[i])
        {
            reference = array[i];
            counter++;
        }
    }

    return counter;
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

// Dictionary<int, int> counter = ElementCounter(matrix);

// foreach(var kvp in counter)
//     Console.WriteLine($"{kvp.Key} встречается {kvp.Value}");

// Dictionary<int, int> ElementCounter(int[,] matrix)
// {
//     Dictionary<int, int> counter = new Dictionary<int, int>();

//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(!counter.ContainsKey(matrix[i, j]))
//                 counter.Add(matrix[i, j], 1);
//             else
//                 counter[matrix[i, j]]++;
//         }
//     }

//     return counter;
// }