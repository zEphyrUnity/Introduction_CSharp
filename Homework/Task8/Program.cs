// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число, для получения ряда четных чисел от 1 до N");
int userNum = TakeUserNum();

Console.Write($"{userNum} -> 2");
for(int i = 4; i <= userNum; i += 2)
{
    Console.Write($", {i}");
}


int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum) | userNum < 2)
    {
        Console.WriteLine("Пожалуйста введите число!");
    }

    return userNum;
}
