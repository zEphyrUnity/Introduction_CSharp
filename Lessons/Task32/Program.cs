// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = RandomArray();
int[] reverseSignArray = ReverseSign(array);
PrintArray(array);
PrintArray(reverseSignArray);

int[] ReverseSign(int[] array)
{
    int[] reverse = new int[array.Length];
    
    for(int i = 0; i < array.Length; i++)
    {
        reverse[i] = array[i] * -1;
    }

    return reverse;
}

int[] RandomArray()
{
    int[] array = new int[10];
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(-10, 11);

    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}