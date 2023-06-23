// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = RandomArray();
PrintArray(array);
Console.WriteLine(OddPositionSum(array));

int OddPositionSum(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];

    return sum;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}

int[] RandomArray()
{
    int[] array = new int[4];
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(100, 1000);

    return array;
}
