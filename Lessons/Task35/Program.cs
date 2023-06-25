// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = RandomArray();
int counter = Counter(array);
PrintArray(array);

Console.WriteLine(counter);

int Counter(int[] array)
{
    int counter = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 & array[i] < 100)
            counter++;
    }

    return counter;
}

int[] RandomArray()
{
    int[] array = new int[12];
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(-10, 150);

    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}