Console.WriteLine("Введите пожалуйста два числа для сравнения");

int a = TakeUserNum();
int b = TakeUserNum();

if(NumComparison(a, b))
{
    Console.WriteLine($"a = {a}; b = {b} -> max = {a}");
}
else
{
    Console.WriteLine($"a = {a}; b = {b} -> max = {b}");
}


int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
    {
        Console.WriteLine("Пожалуйста введите число!");
    }

    return userNum;
}

bool NumComparison(int a, int b)
{
    if(a > b) 
        return true;
    else 
        return false;
}
