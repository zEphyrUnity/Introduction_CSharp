// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей 
// цифры нет.

Console.WriteLine("Пожалуйста введите число");
int value = TakeUserNum();

if(FindThirdNumber(value) == -1)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"{value % 10}");
}

int FindThirdNumber(int value)
{
    if(value < 100)
    {
        return -1;
    }
    else
    {
        while(true)
        {
            if(value > 999)
            {
                value = value / 10;
            }
            else
            {
                return value % 10;
            } 
        } 
    }
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
    {
        Console.WriteLine("Пожалуйста введите число!");
    }

    return Math.Abs(userNum);
}