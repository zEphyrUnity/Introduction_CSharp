// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

const int N = 10;
int[] randomArray = GetRandomArray(N);
int[] copyRandomArray = CopyArray(randomArray);

PrintArray(randomArray);
PrintArray(copyRandomArray);


int[] CopyArray(int[] copied)
{
    int[] copy = new int[copied.Length];

    for(int i = 0; i < copied.Length; i++)
        copy[i] = copied[i];

    return copy;
}

int[] GetRandomArray(int N)
{
    int[] randomArray = new int[N];
    Random random = new Random();

    for(int i = 0; i < N; i++)
        randomArray[i] = random.Next(0, 11);

    return randomArray;
}

void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}