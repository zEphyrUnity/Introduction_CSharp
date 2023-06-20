// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number = TakeUserNum();
int power = TakeUserNum();
int numPower = NumPower(number, power);

Console.WriteLine($"{number}, {power} -> {numPower}");


int NumPower(int number, int exponent)
{
    int numPower = number;

    for(int i = 2; i <= exponent; i++)
        numPower *= number;

    return numPower;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}