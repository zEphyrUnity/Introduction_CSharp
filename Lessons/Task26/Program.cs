// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int userNum = TakeUserNum();

Console.WriteLine(CountNum(userNum));


int CountNum(int userNum)
{
    int i = 0;

    while(userNum > 1)
    {
        userNum /= 10;
        i++;
    }

    return i;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}
