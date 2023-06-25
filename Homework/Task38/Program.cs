using System.Reflection;
using System.Runtime.Intrinsics.X86;
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = RandomArray();
PrintArray(array);
var cortage = FindMinMaxMinus(array);
Console.WriteLine($" => {cortage.Item1:f2} - {cortage.Item2:f2} = {cortage.Item3:f2}");

(double, double, double) FindMinMaxMinus(double[] array)
{
    double min = array[0];
    double max = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
        if(max < array[i]) max = array[i];
    }

    return (max, min, max - min);
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)
            Console.Write($"[{array[i]:f2}, ");
        else if(i != array.Length - 1)
            Console.Write($"{array[i]:f2}, "); 
        else
            Console.Write($"{array[i]:f2}]"); 
    }
}

double[] RandomArray()
{
    double[] array = new double[5];
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = random.NextDouble() * 10;

    return array;
}