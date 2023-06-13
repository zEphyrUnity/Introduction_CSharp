// Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то 
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;

 int num1 = TakeUserNum();
 int num2 = TakeUserNum();

Console.Write($"{num1}, {num2} -> ");
if(num1 % num2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    int reminder = num1 % num2;
    Console.WriteLine($"не кратно, остаток {reminder}");
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