// Задача 19: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно 
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Введите число для проверки на палиндром");
int value = TakeUserNum();

if(IsPalindrome(value))
    Console.WriteLine($"{value} является палиндромом");
else
    Console.WriteLine($"{value} не является палиндромом");


bool IsPalindrome(int value)
{
    int reverse = 0;
    int duplicate = value;

    while(duplicate >= 1)
    {
        reverse = (reverse * 10) + (duplicate % 10);
        duplicate /= 10;
    }

    if(value == reverse)
        return true;
    else
        return false;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum) | (userNum >= Math.Pow(10, 5) & userNum < Math.Pow(10, 6)))
    {
        Console.WriteLine("Пожалуйста введите корректное число!");
    }

    return userNum;
}