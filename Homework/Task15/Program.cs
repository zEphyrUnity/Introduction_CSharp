// Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int weekDayNumber = TakeUserNum();

Array weekDays = Enum.GetValues(typeof(WeekdaysEnum));
Console.WriteLine(weekDays.GetValue(weekDayNumber - 1));

if(weekDayNumber == 6 | weekDayNumber == 7)
{
    Console.WriteLine($"{weekDayNumber} -> да");
}
else
{
    Console.WriteLine($"{weekDayNumber} -> нет");
}


int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum) | (userNum < 1 | userNum > 7))
    {
        Console.WriteLine("Пожалуйста введите корректное число!");
    }

    return userNum;
}

enum WeekdaysEnum : byte
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}