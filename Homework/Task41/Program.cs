// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

const int M = 5;

int[] arrayNum = TakeArrayNum(M);
int counter = CheckPositive(arrayNum);

Console.Clear();
Console.WriteLine($"{string.Join(", ", arrayNum)} -> {counter}");


int CheckPositive(int[] array)
{
    int counter = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) counter++;

    return counter;
}

int[] TakeArrayNum(int M)
{
    int[] array = new int[M];

    for(int i = 0; i < M; i++)
        array[i] = TakeUserNum();

    return array;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}
