// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int value = new Random().Next(100, 1000);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(value);

int thirdValue = value % 10;
int firstValue = value / 100;
int newValue = firstValue * 10 + thirdValue;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(newValue);
