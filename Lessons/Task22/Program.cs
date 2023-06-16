// Задача 22: Напишите программу, которая 
// принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int N = TakeUserNum();
PrintNumPowers(N);


void PrintNumPowers(int N)
{
    for(int i = 1; i <= N; i++)
    {
        if(i == 1)
            Console.Write(i);
        else
            Console.Write($", {Math.Pow(i, 2)}");
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
