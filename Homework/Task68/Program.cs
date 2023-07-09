// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = TakeUserNum();
int n = TakeUserNum();

int akkermanValue = AkkermanFunc(m, n);
Console.WriteLine($"m = {m}, n = {n} - A(m,n) = {akkermanValue}");

int AkkermanFunc(int m, int n)
{
    if(m == 0) 
        return n + 1;
    else if((m != 0) && (n == 0)) 
        return AkkermanFunc(m - 1, 1);
    else 
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

int TakeUserNum(int num = 0)
{
    int userNum = 0;

    if(num < 0)
    {
        Console.WriteLine("Пожалуйста введите число больше нуля!");

        while(!int.TryParse(Console.ReadLine(), out userNum))
            Console.WriteLine("Пожалуйста введите число!");
    }
    else
        while(!int.TryParse(Console.ReadLine(), out userNum))
            Console.WriteLine("Пожалуйста введите число!");

    if(userNum < 0) return TakeUserNum(userNum);

    return userNum;
}