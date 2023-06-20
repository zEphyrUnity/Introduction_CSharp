// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int userNum = TakeUserNum();
Console.WriteLine(DigitAmount(userNum));

int DigitAmount(int value)
{
    int amount = 0;

    while(value >= 1)
    {
        amount += value % 10;
        value /= 10;
    }

    return amount;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}
