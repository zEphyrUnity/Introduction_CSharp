// 14. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите число для проверки на кратность 7 и 23");
Console.ForegroundColor = ConsoleColor.Yellow;

int value = TakeUserNum();

if(value % 7 == 0 & value % 23 == 0)
{
    Console.WriteLine($"{value} -> да");
}
else
{
     Console.WriteLine($"{value} -> нет");
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