// Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.

Console.Clear();
Console.WriteLine("Введите пожалуйста трёхзначное число");

int value = TakeUserNum();
Console.WriteLine((value / 10) % 10);

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum) | (userNum < 100 | userNum > 999))
    {
        Console.WriteLine("Пожалуйста введите трёхзначное число!");
    }

    return userNum;
}

