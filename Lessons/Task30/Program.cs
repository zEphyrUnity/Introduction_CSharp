// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

const int ARRAYSIZE = 8;
int[] randomBinaryArray = RandomBinaryArray();
PrintArray(randomBinaryArray);

int[] RandomBinaryArray()
{
    int[] array = new int[ARRAYSIZE];
    Random randomName = new Random();

    for(int i = 0; i < ARRAYSIZE; i++)
        array[i] = randomName.Next(0, 2);

    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}