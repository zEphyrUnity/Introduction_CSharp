// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

const int N = 8;
int[] randomArray = GetRandomArray(N);

PrintArrayHard(randomArray);


void PrintArrayHard(int[] array)
{
    foreach(var (value, i) in array.Select((value, i) => (value, i)))
    {
        if(i != array.Length - 1)
            Console.Write($"{value}, ");
        else
            Console.Write($"{value} -> ");
    }

    foreach(var (value, i) in array.Select((value, i) => (value, i)))
    {
        if(i == 0)
            Console.Write($"[{value}, ");
        else if(i != array.Length - 1)
            Console.Write($"{value}, "); 
        else
            Console.Write($"{value}]"); 
    }

    Console.WriteLine();
}

int[] GetRandomArray(int N)
{
    int[] randomArray = new int[N];
    Random random = new Random();

    for(int i = 0; i < N; i++)
        randomArray[i] = random.Next(0, 11);

    return randomArray;
}