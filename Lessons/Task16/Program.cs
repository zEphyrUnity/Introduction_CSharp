// 16. Напишите программу, которая принимает на 
// вход два числа и проверяет, является ли одно 
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
int value1 = TakeUserNum();
Console.ForegroundColor = ConsoleColor.DarkGreen;
int value2 = TakeUserNum();

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"{value1}, {value2} -> ");
Console.ForegroundColor = ConsoleColor.DarkRed;

if(value1 * value1 == value2 | value2 * value2 == value1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
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