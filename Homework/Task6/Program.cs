// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число, для проверки на чётность");
int userNum = TakeUserNum();
bool isEven = IsEvenNumber(userNum);

if(isEven)
    Console.WriteLine($"{userNum} -> да");
else
    Console.WriteLine($"{userNum} -> нет");


int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
    {
        Console.WriteLine("Пожалуйста введите число!");
    }

    return userNum;
}

bool IsEvenNumber(int userNum)
{
    if(userNum % 2 == 0) 
        return true;
    else 
        return false;
}