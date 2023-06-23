// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число");
int userNumber = TakeUserNum();
int[] array = RandomArray();
PrintArray(array);

if(FindUserNum(userNumber, array))
    Console.WriteLine($"Число {userNumber} содержится в массиве");
else
    Console.WriteLine($"Число {userNumber} Не содержится в массиве");


bool FindUserNum(int userNumber, int[] array)
{
    bool isFind = false;

    foreach(var element in array)
    {
        if(element == userNumber)
            isFind = true;
    }

    return isFind;
}

int[] RandomArray()
{
    int[] array = new int[10];
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(-5, 5);

    return array;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}
