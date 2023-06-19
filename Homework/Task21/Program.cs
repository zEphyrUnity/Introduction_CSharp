// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

int X1 = TakeUserNum();
int Y1 = TakeUserNum();
int Z1 = TakeUserNum();
int X2 = TakeUserNum();
int Y2 = TakeUserNum();
int Z2 = TakeUserNum();

double AB = Distance(X1, X2, Y1, Y2, Z1, Z2);

Console.WriteLine(AB);

double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
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
