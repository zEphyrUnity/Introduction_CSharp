//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int quarter = TakeUserNum();
FindQuarter(quarter);

void FindQuarter(int quarter)
{
    if(quarter == 1)
    {
        Console.WriteLine("X > 0, Y > 0");
    }
    else if(quarter == 2)
    {
        Console.WriteLine("X < 0, Y > 0");
    }
    else if(quarter == 3)
    {
        Console.WriteLine("X < 0, Y < 0");
    }
    else if(quarter == 4)
    {
        Console.WriteLine("X > 0, Y < 0");
    }
    else
    {
        Console.WriteLine("Такой четверти не существует");
    }
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