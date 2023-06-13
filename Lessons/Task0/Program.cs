/*Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
на само себя).

Например:
4-> 16
- 3-> 9
- 7-> 49*/

int.TryParse(Console.ReadLine(), out int result);
Console.WriteLine($"Квадрат числа {result} = {result * result}");  