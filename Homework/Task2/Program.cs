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
