// Задача 28: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int N = TakeUserNum();
Console.WriteLine($"{N} -> {ProductNum(N)}");

int ProductNum(int N)
{
    int product = 1;

    for(int i = 1; i <= N; i++)
        product *= i; // product = product * i

    return product;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}