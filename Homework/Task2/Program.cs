// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите пожалуйста два числа для сравнения");

int a = TakeUserNum();
int b = TakeUserNum();
int max = NumComparison(a, b);

Console.WriteLine($"a = {a}; b = {b} -> max = {max}");

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
    {
        Console.WriteLine("Пожалуйста введите число!");
    }

    return userNum;
}

int NumComparison(int a, int b)
{
    int max = a;

    if(max < b) max = b;

    return max;
}
