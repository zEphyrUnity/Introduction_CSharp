// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1 = TakeUserNum();
int k1 = TakeUserNum();
int b2 = TakeUserNum();
int k2 = TakeUserNum();

var intersection = Intersection(b1, k1, b2, k2);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({intersection.Item1}; {intersection.Item2})");


(double, double) Intersection(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;

    if(k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают");
    else if(k1 == k2)
        Console.WriteLine("Прямые паралельны");
    else
    {
        x = (b2-b1) / (k1-k2); 
        y = ( k1 * (b2 - b1)) / (k1 - k2) + b1;
    }

    return(x, y);
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}