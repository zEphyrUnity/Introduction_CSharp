// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.
// [345, 897, 568, 234] -> 2

int[] array = RandomArray();
PrintArray(array);
Console.WriteLine(OddCount(array));

int OddCount(int[] array)
{
    int counter = 0;

    foreach(var element in array)
        if(element % 2 == 0) counter++;

    return counter;
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