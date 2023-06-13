using Microsoft.CSharp.RuntimeBinder;
// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей 
// цифры нет.

int value = TakeUserNum();

if(value < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else if(value > 99 & value < 1000)
{
    Console.WriteLine($"{value % 10}");
}
else
{
    while(true)
    {
        if(value > 999)
        {
            value = value / 10;
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine($"{value % 10}");
            return;
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

    return userNum;
}