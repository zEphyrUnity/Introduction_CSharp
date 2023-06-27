// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}

string BinaryConvert(int userNum)
{
    string binary = "";

    while(userNum >= 1)
    {
        binary = userNum % 2 + binary;
        userNum /= 2;
    }

    return binary;
}

Console.WriteLine(BinaryConvert(TakeUserNum()));