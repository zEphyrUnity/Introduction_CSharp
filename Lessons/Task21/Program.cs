// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √ (x b - x a)^2 + (y b - y a)^2

int X1 = TakeUserNum();
int Y1 = TakeUserNum();
int X2 = TakeUserNum();
int Y2 = TakeUserNum();

double AB = Distance(X1, X2, Y1, Y2);

Console.WriteLine(AB);

double Distance(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
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

