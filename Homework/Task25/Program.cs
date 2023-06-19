// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = TakeUserNum();
int B = TakeUserNum();
int power = NumPower(A, B);

Console.WriteLine($"{A}, {B} -> {power}");


int NumPower(int A, int B)
{
    int numPower = A;

    for(int i = 2; i <= B; i++)
        numPower *= A;

    return numPower;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}