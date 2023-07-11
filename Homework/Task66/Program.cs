// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = TakeUserNum();
int N = TakeUserNum();

Console.WriteLine($"M = {M}; N = {N} -> {RecursionRangeSum(M, N)}");


int RecursionRangeSum(int m, int n)
{
    if(m == n) return m;

    return RecursionRangeSum(m + 1, n) + m;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}